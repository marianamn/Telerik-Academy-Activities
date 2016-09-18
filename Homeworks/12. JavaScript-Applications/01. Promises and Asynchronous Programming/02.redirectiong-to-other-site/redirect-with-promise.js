(function(){
    let messageElement = document.getElementById('message'),
        site = 'http://telerikacademy.com/';

    
    function redirectToOtherSite(){
        return new Promise((resolve, reject) => {
            resolve('After 2 sec you will be redirected to --> '),
            (error) => reject(error)
        })
    }

    function showMessageForRedirection(message){
        messageElement.innerText = message + site;

        return site;
    }

    function redirectToSiteAfterTwoSeconds(site){
        setInterval(function () {
            window.location.href = site;
        }, 2000);
    }

    redirectToOtherSite()
        .then(showMessageForRedirection)
        .then(redirectToSiteAfterTwoSeconds);

    //console.log(redirectToOtherSite()
    //    .then(showMessageForRedirection));
}());
