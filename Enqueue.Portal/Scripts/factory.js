EnqueueApp.factory('enqueueService', ['$http', function ($http) {

    var enqueueService = {};
    enqueueService.getStudents = function () {
        return $http.get('/api/values');
    };
    return enqueueService;

}]);