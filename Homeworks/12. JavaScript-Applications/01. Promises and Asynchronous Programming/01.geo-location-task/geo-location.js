(function(){
    let locationElement = document.getElementById('geo-location-img')

    function getGeoLocationPosition(){
        return new Promise((resolve, reject) =>{
            navigator.geolocation.getCurrentPosition(
                (position) => resolve(position),
                (error) => reject(error)
            )
        })
    }

    function parsePositionLongitudeAndLagitute(geolocationPosition){
        if(geolocationPosition.coords){
            return {
                latitude: geolocationPosition.coords.latitude,
                longitude: geolocationPosition.coords.longitude
            }
        }else {
            throw {
                message: "No coordinates element found",
                name: "UserException"
            };
        }
    }

    function createLocationImage(coordinates){
        let img = document.createElement('img'),
            imgSrc = "http://maps.googleapis.com/maps/api/staticmap?center=" +
                coordinates.latitude + "," +
                coordinates.longitude +
                "&zoom=13&size=500x500&sensor=false";

        img.setAttribute('src', imgSrc);
        locationElement.appendChild(img);
    }

    getGeoLocationPosition()
        .then(parsePositionLongitudeAndLagitute)
        .then(createLocationImage);

    //console.log(getGeoLocationPosition()
    //   .then(parsePositionLongitudeAndLagitute)
    //   .then(createLocationImage);
}());
