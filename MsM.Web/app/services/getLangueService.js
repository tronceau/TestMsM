app.factory('getLangueService', function ($resource) {

    var uri = 'http://localhost/MSM.API/api/Langue';

    return $resource(
        uri,
        {
            callback: 'JSON_CALLBACK'
        },
        {
            get: { method: 'JSONP' }
        });

});