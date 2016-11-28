//*********************************************************************************
//Purpose: Defines the 'logger' factory for Server Side Logging.
//Modified At: MM/DD/YYYY                    Modified By:
//Reason:
//*********************************************************************************
var app = angular.module('myApp');

app.factory('logger', ['$http', 'toaster', function ($http, toaster) {
    var service = {
        logInfo: logInfo,
        logWarning: logWarning,
        logSuccess: logSuccess,
        logError: logError
    };
    return service;



    function logInfo(msg, title, onlyNotify) {
        toaster.pop("note", title, msg);
        //server side logging
        if (onlyNotify != undefined && !onlyNotify) {
            //serverLogger.notifyServer(msg, "info");
        }

    }
    function logWarning(msg, title, onlyNotify) {
        toaster.pop("warning", title, msg);
        //server side logging
        if (onlyNotify != undefined && !onlyNotify) {
            //serverLogger.notifyServer(msg, "warn");
        }
    }
    function logError(msg, title, onlyNotify) {
        toaster.pop("error", title, msg);
        //server side logging
        if (onlyNotify != undefined && !onlyNotify) {
            //serverLogger.notifyServer(msg, "error");
        }
    }
    function logSuccess(msg, title) {
        toaster.pop("success", title, msg);
    }

}])

//(function () {
//    'use strict';

//    angular
//        .module('myApp')
//        .factory('logger', logger); 

//    logger.$inject = ['$http', 'toaster'];

//    function logger($http, toaster) {
//        var service = {
//            logInfo: logInfo,
//            logWarning: logWarning,
//            logSuccess: logSuccess,
//            logError: logError
//        };
//        return service;

//        function logInfo(msg,title,onlyNotify) {
//            toaster.pop("note", title, msg);
//            //server side logging
//            if (onlyNotify!=undefined && !onlyNotify) {
//                //serverLogger.notifyServer(msg, "info");
//            }

//        }
//        function logWarning(msg, title, onlyNotify) {
//            toaster.pop("warning", title, msg);
//            //server side logging
//            if (onlyNotify != undefined && !onlyNotify) {
//                //serverLogger.notifyServer(msg, "warn");
//            }
//        }
//        function logError(msg, title, onlyNotify) {
//            toaster.pop("error", title, msg);
//            //server side logging
//            if (onlyNotify != undefined && !onlyNotify) {
//                //serverLogger.notifyServer(msg, "error");
//            }
//        }
//        function logSuccess(msg, title) {
//            toaster.pop("success", title, msg);
//        }
//    }
//})();