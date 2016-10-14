// http://paulirish.com/2011/requestanimationframe-for-smart-animating/
// http://my.opera.com/emoller/blog/2011/12/20/requestanimationframe-for-smart-er-animating
// requestAnimationFrame polyfill by Erik Möller. fixes from Paul Irish and Tino Zijdel
// MIT license

/* globals window document console */
"use strict";
window.requestAnimFrame = (function(callback) {
    return window.requestAnimationFrame || window.webkitRequestAnimationFrame || window.mozRequestAnimationFrame || window.oRequestAnimationFrame || window.msRequestAnimationFrame ||
        function(callback) {
            window.setTimeout(callback, 1000 / 60);
        };
})();
window.onload = function() {
    var game = createGame("#field-canvas", "#block-canvas", "#next-canvas");
    //game.start();
    document.getElementById('startSound').play();
    document.getElementById('coolTetrisVoice').play();
    //document.getElementById('originalTheme').play();
    // prevents page scrolling when using arrow keys
    window.addEventListener("keydown", function(e) {
        // space and arrow keys
        if ([32, 37, 38, 39, 40].indexOf(e.keyCode) > -1) {
            e.preventDefault();
        }
    }, false);
};

const startGameField = {
        "shape": [
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
            [0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
            [0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1]
        ],
        "color": "rgb(56, 92, 122)"
    },
    blocks = [{
        "shapes": [
            [
                [1, 1, 1],
                [0, 1, 0]
            ],
            [
                [0, 1],
                [1, 1],
                [0, 1]
            ],
            [
                [0, 1, 0],
                [1, 1, 1]
            ],
            [
                [1, 0],
                [1, 1],
                [1, 0]
            ]
        ],
        "color": "rgb(89, 204, 9)",
        "state": 0
    }, {
        "shapes": [
            [
                [1, 1],
                [1, 0]
            ],
            [
                [1, 1],
                [0, 1]
            ],
            [
                [0, 1],
                [1, 1]
            ],
            [
                [1, 0],
                [1, 1]
            ]
        ],
        "color": "rgb(58, 116, 204)",
        "state": 0
    }, { //cube
        "shapes": [
            [
                [1, 1],
                [1, 1]
            ],
            [
                [1, 1],
                [1, 1]
            ],
            [
                [1, 1],
                [1, 1]
            ],
            [
                [1, 1],
                [1, 1]
            ]
        ],
        "color": "rgb(196, 44, 227)",
        "state": 0
    }, { //stretched cube #1 or s-shaped
        "shapes": [
            [
                [1, 0],
                [1, 1],
                [0, 1]
            ],
            [
                [0, 1, 1],
                [1, 1, 0]
            ],
            [
                [1, 0],
                [1, 1],
                [0, 1]
            ],
            [
                [0, 1, 1],
                [1, 1, 0]
            ]
        ],
        "color": "rgb(244, 81, 21)",
        "state": 0
    }, { //stretched cube #2 or s-shaped
        "shapes": [
            [
                [0, 1],
                [1, 1],
                [1, 0]
            ],
            [
                [1, 1, 0],
                [0, 1, 1]
            ],
            [
                [0, 1],
                [1, 1],
                [1, 0]
            ],
            [
                [1, 1, 0],
                [0, 1, 1]
            ]
        ],
        "color": "rgb(255, 247, 54)",
        "state": 0
    }, { //bulgarian Г-shaped #1
        "shapes": [
            [
                [1, 1],
                [1, 0],
                [1, 0]
            ],
            [
                [1, 1, 1],
                [0, 0, 1]
            ],
            [
                [0, 1],
                [0, 1],
                [1, 1]
            ],
            [
                [1, 0, 0],
                [1, 1, 1]
            ]
        ],
        "color": "rgb(22, 191, 135)",
        "state": 0
    }, { //bulgarian Г-shaped inverted
        "shapes": [
            [
                [1, 1],
                [0, 1],
                [0, 1]
            ],
            [
                [0, 0, 1],
                [1, 1, 1]
            ],
            [
                [1, 0],
                [1, 0],
                [1, 1]
            ],
            [
                [1, 1, 1],
                [1, 0, 0]
            ]
        ],
        "color": "rgb(252, 42, 121)",
        "state": 0
    }, { //I-shaped
        "shapes": [
            [
                [1],
                [1],
                [1],
                [1]
            ],
            [
                [1, 1, 1, 1]
            ],
            [
                [1],
                [1],
                [1],
                [1]
            ],
            [
                [1, 1, 1, 1]
            ]
        ],
        "color": "rgb(34, 235, 144)",
        "state": 0
    }, { //blinking block
        "shapes": [
            [
                [1]
            ],
            [
                [1]
            ],
            [
                [1]
            ],
            [
                [1]
            ]
        ],
        "color": "rgb(6, 166, 176)",
        "blinkColor": "rgb(107, 229, 246)",
        "state": 0
    }];

function createGame(fieldSelector, blockSelector, tetrisNextSelector) {

    const buildBlockSize = 15,
        blockDirections = 4,
        step = buildBlockSize,
        blockLineWidth = 2,
        //blockLineColor = "green",
        //emptyFieldColor = "white",
        fieldWidth = startGameField.shape[0].length,
        fieldHeight = startGameField.shape.length,
        enterFieldLeft = 10,
        enterFieldTop = 0;

    var fieldCanvas = document.querySelector(fieldSelector),
        blockCanvas = document.querySelector(blockSelector),
        tetrisNextCanvas = document.querySelector(tetrisNextSelector),
        ctxBlocks = blockCanvas.getContext("2d"),
        ctxField = fieldCanvas.getContext("2d"),
        ctxTetrisNext = tetrisNextCanvas.getContext("2d"),
        gotToBottom = false,
        nextBlock = getRandomBlock(),
        tetrisBlock = getRandomBlock(),
        currentFieldPosition = {
            "left": enterFieldLeft,
            "top": enterFieldTop
        },
        speed,
        gameField = startGameField,
        counterPoints = 0,
        lines = 0,
        level = 1,
        isPushedStart = false,
        isMuted = false,
        isBlink = false,
        isNextFreePosition,
        interval,
        gameLoops,
        isOver=false;

    function drawGameFieldBlocks(field, ctx) {
        //console.log("drawing field");
        for (let i = 0; i < field.shape.length; i += 1) {
            for (let j = 0; j < field.shape[0].length; j += 1) {
                if (field.shape[i][j] === 1) {
                    drawSingleBlock({
                        "left": j,
                        "top": i,
                        "size": buildBlockSize,
                        "color": field.color,
                        "lineColor": "rgb(255, 255, 255)"
                    }, ctx);
                } else {
                    drawSingleBlock({
                        "left": j,
                        "top": i,
                        "size": buildBlockSize,
                        "color": "rgba(0, 0, 0, 0)",
                        "lineColor": "rgba(0, 0, 0, 0)"
                    }, ctx);
                }
            }
        }
    }

    function drawSingleBlock(block, ctx) {
        ctx.fillStyle = block.color;
        ctx.strokeStyle = block.lineColor;
        ctx.lineWidth = blockLineWidth;
        ctx.beginPath();
        ctx.fillRect(block.left * block.size, block.top * block.size, block.size, block.size);
        ctx.strokeRect(block.left * block.size, block.top * block.size, block.size, block.size);
    }

    function drawTetrisBlock(pattern, position, ctx) {
        var shape = pattern.shapes[pattern.state],
            vLen = shape.length,
            hLen;

        for (let v = 0; v < vLen; v += 1) {
            hLen = shape[v].length;
            for (let h = 0; h < hLen; h += 1) {
                if (shape[v][h] === 1) {
                    if (!pattern.blinkColor) {
                        drawSingleBlock({
                            "left": position.left + h,
                            "top": position.top + v,
                            "size": buildBlockSize,
                            "color": pattern.color,
                            "lineColor": "rgb(255, 255, 255)"
                        }, ctx);
                    } else {
                        if (!isBlink) {
                            drawSingleBlock({
                                "left": position.left + h,
                                "top": position.top + v,
                                "size": buildBlockSize,
                                "color": pattern.color,
                                "lineColor": "rgb(255, 255, 255)"
                            }, ctx);
                            isBlink = true;
                        } else {
                            drawSingleBlock({
                                "left": position.left + h,
                                "top": position.top + v,
                                "size": buildBlockSize,
                                "color": pattern.blinkColor,
                                "lineColor": "rgb(255, 255, 255)"
                            }, ctx);
                            isBlink = false;
                        }
                    }
                }
            }
        }
    }

    function getRandomBlock() {
        var randBlock = blocks[Math.floor(Math.random() * blocks.length)];
        randBlock.state = Math.floor(Math.random() * blockDirections);
        return randBlock;
    }

    function isValidBlockPosition(position) {
        var currShape = tetrisBlock.shapes[tetrisBlock.state],
            vLen = currShape.length,
            hLen;

        //Check for LEFT boundary
        if (position.left < 0) {
            return false;
        }
        //Check for RIGHT boundary
        if (position.left + currShape[0].length > fieldWidth) {
            return false;
        }
        //Check for BOTTOM boundary
        if (position.top + currShape.length > fieldHeight) {
            return false;
        }

        //Check for COLLISION inside the field
        for (let v = 0; v < vLen; v += 1) {
            hLen = currShape[v].length;
            for (let h = 0; h < hLen; h += 1) {

                //Check for game over (could also take it out in a separate function)
                if (position.top === 1 &&
                    gameField.shape[position.top + v][position.left + h] === 1) {
                    isOver = true;
                }
                //End of game-over piece

                if (currShape[v][h] === 1 &&
                    gameField.shape[position.top + v][position.left + h] === 1) {
                    return false;
                }
            }
        }

        return true;
    }

    function respondToKeyDown(ev) {
        switch (ev.keyCode) {
            case 37:
                { //left
                    //play sound
                    document.getElementById('moveLeftRight').play();
                    currentFieldPosition.left -= 1;
                    if (!isValidBlockPosition(currentFieldPosition)) {
                        currentFieldPosition.left += 1;
                    }
                    ctxBlocks.clearRect(0, 0, blockCanvas.clientWidth, blockCanvas.clientHeight);
                    drawTetrisBlock(tetrisBlock, currentFieldPosition, ctxBlocks);
                    break;
                }
            case 39:
                { //right
                    document.getElementById('moveLeftRight').play();
                    currentFieldPosition.left += 1;
                    if (!isValidBlockPosition(currentFieldPosition)) {
                        currentFieldPosition.left -= 1;
                    }
                    ctxBlocks.clearRect(0, 0, blockCanvas.clientWidth, blockCanvas.clientHeight);
                    drawTetrisBlock(tetrisBlock, currentFieldPosition, ctxBlocks);
                    break;
                }
            case 38:
                { //up: rotate clockwise
                    document.getElementById('rotateLeftRight').play();

                    var prevState = tetrisBlock.state;
                    tetrisBlock.state = (tetrisBlock.state + 1) % blockDirections;
                    if (!isValidBlockPosition(currentFieldPosition)) {
                        tetrisBlock.state = prevState;
                    }
                    ctxBlocks.clearRect(0, 0, blockCanvas.clientWidth, blockCanvas.clientHeight);
                    drawTetrisBlock(tetrisBlock, currentFieldPosition, ctxBlocks);
                    break;
                }
            case 40:
                { //down: interval - position block to bottom
                    document.getElementById('fallDown').play();
                    moveBlockDown();
                    break;
                }
            default:
                break;
        }
    }

    function drawBlockOnField() {
        currentFieldPosition.top -= 1;
        updateGameFieldWithBlock();
        ctxField.clearRect(0, 0, fieldCanvas.clientWidth, fieldCanvas.clientHeight);
        drawGameFieldBlocks(gameField, ctxField);

        gotToBottom = true;
    }

    function moveBlockDown() {
        currentFieldPosition.top += 1;
        if (!isValidBlockPosition(currentFieldPosition)) {
            if (!tetrisBlock.blinkColor) {
                drawBlockOnField();
            } else if (tetrisBlock.blinkColor) {
                isNextFreePosition = false;
                let nextPosition = {
                    top: currentFieldPosition.top + 1,
                    left: currentFieldPosition.left
                }
                for (nextPosition.top; nextPosition.top < fieldHeight; nextPosition.top += 1) {
                    if (isValidBlockPosition(nextPosition)) {
                        isNextFreePosition = true;
                        break;
                    }
                }
                if (!isNextFreePosition) {
                    drawBlockOnField();
                } else {
                    ctxBlocks.clearRect(0, 0, blockCanvas.clientWidth, blockCanvas.clientHeight);
                    drawTetrisBlock(tetrisBlock, currentFieldPosition, ctxBlocks);
                }
            }
        } else {
            ctxBlocks.clearRect(0, 0, blockCanvas.clientWidth, blockCanvas.clientHeight);
            drawTetrisBlock(tetrisBlock, currentFieldPosition, ctxBlocks);
        }
        //sound for down
        document.getElementById('fallDown').play();


    }

    function updateSpeed() {
        moveBlockDown();
        interval = setTimeout(updateSpeed, speed);
        //console.log(lines);
        //console.log(speed);
    }

    function updateGameFieldWithBlock() {
        var currShape = tetrisBlock.shapes[tetrisBlock.state],
            vLen = currShape.length,
            hLen;

        for (let v = 0; v < vLen; v += 1) {
            hLen = currShape[v].length;
            for (let h = 0; h < hLen; h += 1) {
                if (currShape[v][h] === 1) {
                    gameField.shape[currentFieldPosition.top + v][currentFieldPosition.left + h] = 1;

                }
            }
        }
    }

    function getRandomLine(){
      var arr= [];
      for (let i = 0; i < fieldWidth; i+=1)
        arr.push(Math.round(Math.random()));
      return arr;
    }

    function updateGameFieldWithLine() {
      var line = getRandomLine();
      gameField.shape.push(line);
      gameField.shape.shift();
    }

    function clearFullRows(ctx) {
        var vLen = startGameField.shape[0].length, //length of rows = 20
            hLen = startGameField.shape.length, // length of cols = 40
            countRow = 0,
            zeroArray = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

        for (let h = 0; h < hLen; h += 1) {
            for (let v = 0; v < vLen; v += 1) {
                countRow += startGameField.shape[h][v];
            }
            if (countRow === 20) // check if all are 1
            {
                startGameField.shape.splice(h, 1); // remove row
                startGameField.shape.unshift(zeroArray); // add zeroArray at front
                counterPoints += 1;
                lines += 1;

                if (lines % 5 == 0) {
                    level += 1;
                    //sound for levelUp
                    document.getElementById("levelUpSound").play();
                    updateGameFieldWithLine();
                }

                ctx.clearRect(0, 0, fieldCanvas.clientWidth, fieldCanvas.clientHeight);
                drawGameFieldBlocks(gameField, ctx);
            }

            countRow = 0;

            document.getElementById('result').innerHTML = counterPoints * 10;

            document.getElementById('level').innerHTML = level;

            //restarting when 250 points reached
            /*if(document.getElementById('result').innerHTML>=1000){

              if (confirm("You win!! You reached 250 points! Press OK to restart the game!")) {
                        alert("Thanks for that!");
              } else {
                        alert("Why did you press cancel? Press Ok next time :) :) !");
              }

             refresh();}*/
        }

    }

    function gameLoop() {
        speed = 800 - lines * 10;

        if (gotToBottom) {
            tetrisBlock = nextBlock;
            nextBlock = getRandomBlock();

            currentFieldPosition = {
                "left": enterFieldLeft,
                "top": enterFieldTop
            };
            gotToBottom = false;
        }

        var nextFieldPosition = {
            "left": 5,
            "top": 2
        };

        ctxTetrisNext.clearRect(0, 0, tetrisNextCanvas.clientWidth, tetrisNextCanvas.clientHeight);
        drawTetrisBlock(nextBlock, nextFieldPosition, ctxTetrisNext);

        clearFullRows(ctxField);
        if(!isOver){
            gameLoops = window.requestAnimationFrame(gameLoop);
        }else{
            document.getElementById("game-over").style.display = "block";
        }
        console.log(isOver);
    }

    ctxField.canvas.width = fieldWidth * buildBlockSize;
    ctxField.canvas.height = fieldHeight * buildBlockSize;
    ctxBlocks.canvas.width = fieldWidth * buildBlockSize;
    ctxBlocks.canvas.height = fieldHeight * buildBlockSize;

    ctxBlocks.font = "18px monospace";
    ctxBlocks.fillStyle = "rgb(64, 118, 124)";
    ctxBlocks.strokeStyle = "rgb(64, 118, 124)";
    ctxBlocks.fillText("CLICK 'Start'", 80, 100);
    ctxBlocks.strokeText("CLICK 'Start'", 80, 100);
    ctxBlocks.fillText("BUTTON TO BEGIN GAME!", 50, 130);
    ctxBlocks.strokeText("BUTTON TO BEGIN GAME!", 50, 130);
    ctxBlocks.fillText("controls:", 30, 200);
    ctxBlocks.strokeText("controls:", 30, 200);
    ctxBlocks.fillText("up    - rotate block", 30, 230);
    ctxBlocks.strokeText("up", 30, 230);
    ctxBlocks.fillText("down  - speed up", 30, 260);
    ctxBlocks.strokeText("down", 30, 260);
    ctxBlocks.fillText("right - move to the right", 30, 290);
    ctxBlocks.strokeText("right", 30, 290);
    ctxBlocks.fillText("left  - move to the left", 30, 320);
    ctxBlocks.strokeText("left", 30, 320);

    document.body.addEventListener("keydown", respondToKeyDown);


    document.getElementById('start').addEventListener('click', function() {
        if (isPushedStart === false) {
            setTimeout(updateSpeed, speed);
            isPushedStart = true; //starting the game
            this.innerText = "Pause";
            drawGameFieldBlocks(gameField, ctxField);

            ctxBlocks.clearRect(0, 0, blockCanvas.clientWidth, blockCanvas.clientHeight);
            drawTetrisBlock(tetrisBlock, currentFieldPosition, ctxBlocks);
        } else {
            clearTimeout(interval);
            isPushedStart = false; // pausing the game
            this.innerText = "Start";
        }
    });

    //sounds mute
    var audio = document.getElementById('coolTetrisVoice');

    document.getElementById('muteSound').addEventListener('click', function() {
        var audios = document.querySelectorAll('audio');
        if (isMuted === false) {
            isMuted = true; //starting the game
            this.innerText = "Unmute";
            [].forEach.call(audios, function(audio) {
                audio.muted = true;
                audio.pause();
            });
        } else {
            isMuted = false;
            this.innerText = "Mute";
            [].forEach.call(audios, function(audio) {
                audio.muted = false;
            });
        }
    });
    return gameLoop();
}

function refresh() {
    //refreshing the page function

    setTimeout(function() {
        location.reload()
    },3000);
}
