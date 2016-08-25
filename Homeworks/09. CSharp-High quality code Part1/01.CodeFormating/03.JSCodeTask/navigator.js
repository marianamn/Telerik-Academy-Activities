// JSLint is used as a tool

var b,
    addScroll = false,
    turnOff = 0,
    text = "",
    positionX = 0,
    positionY = 0,
    event,
    window,
    navigator,
    document,
    theLayer,
    mouseMove;

b = navigator.appName;

if ((navigator.userAgent.indexOf('MSIE 5') > 0) ||
        (navigator.userAgent.indexOf('MSIE 6') > 0)) {
    addScroll = true;
}

document.onmousemove = mouseMove;

if (b === "Netscape") {
    document.captureEvents(event.MOUSEMOVE);
}

function popTip() {
    if (b === "Netscape") {
        theLayer = eval('document.layers[\'ToolTip\']');

        if ((positionX + 120) > window.innerWidth) {
            positionX = window.innerWidth - 150;
        }

        theLayer.left = positionX + 10;
        theLayer.top = positionY + 15;
        theLayer.visibility = 'show';
    } else {
        theLayer = eval('document.all[\'ToolTip\']');

        if (theLayer) {
            positionX = event.x - 5;
            positionY = event.y;

            if (addScroll) {
                positionX = positionX + document.body.scrollLeft;
                positionY = positionY + document.body.scrollTop;
            }

            if ((positionX + 120) > document.body.clientWidth) {
                positionX = positionX - 150;
            }

            theLayer.style.pixelLeft = positionX + 10;
            theLayer.style.pixelTop = positionY + 15;
            theLayer.style.visibility = 'visible';
        }
    }
}

function mouseMove(evn) {
    'use strict';

    if (b === "Netscape") {
        positionX = evn.pageX - 5;
        positionY = evn.pageY;
    } else {
        positionX = event.x - 5;
        positionY = event.y;
    }

    if (b === "Netscape") {
        if ('document.layers[\'ToolTip\']'.visibility === 'show') {
            popTip();
        }
    } else {
        if ('document.all[\'ToolTip\']'.style.visibility === 'visible') {
            popTip();
        }
    }
}

function hideTip() {
    'use strict';

    //var args = hideTip.arguments;
    if (b === "Netscape") {
        'document.layers[\'ToolTip\']'.visibility = 'hide';
    } else {
        'document.all[\'ToolTip\']'.style.visibility = 'hidden';
    }
}

function hideFirstMenu() {
    'use strict';

    if (b === "Netscape") {
        'document.layers[\'ToolTip\']'.visibility = 'hide';
    } else {
        'document.all[\'ToolTip\']'.style.visibility = 'hidden';
    }
}

function showFirstMenu() {
    var theLayer;

    if (b === "Netscape") {
        theLayer = eval('document.layers[\'menu1\']');
        theLayer.visibility = 'show';
    } else {
        theLayer = eval('document.all[\'menu1\']');
        theLayer.style.visibility = 'visible';
    }
}

function hideSecondMenu() {
    'use strict';

    if (b === "Netscape") {
        'document.layers[\'menu2\']'.visibility = 'hide';
    } else {
        'document.all[\'menu2\']'.style.visibility = 'hidden';
    }
}

function showSecondMenu() {
    'use strict';

    if (b === "Netscape") {
        theLayer = eval('document.layers[\'menu2\']');
        theLayer.visibility = 'show';
    } else {
        theLayer = eval('document.all[\'menu2\']');
        theLayer.style.visibility = 'visible';
    }
}