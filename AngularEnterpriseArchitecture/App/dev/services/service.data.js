'use strict';

(function (ag) {
    ag.service('DataService', ['$q', 'CacheFactory', '$timeout', function ($q, CacheFactory, $timeout) {

        /*
            Internal logic
        ----------------------------------- */
        if (!CacheFactory.get('dataCache')) {
            CacheFactory.createCache('dataCache', {
                maxAge: 3600000
            });
        }

        var _dataCache = CacheFactory.get('dataCache');

        /*
            Service methods
        ----------------------------------- */
        this.getDataById = function (id) {
            console.info(":: DataService -> getDataById: " + id);

            var def = $q.defer();

            if (_dataCache.get(id)) {
                def.resolve(_dataCache.get(id));
            } else {
                // Get data from backend service via $http
                // ...

                // Put data from backend into cache
                _dataCache.put(id, { some: 'value' });

                def.resolve(_dataCache.get(id));
            }

            return def.promise;
        };

        this.getDataWithDelay = function (delay) {

            console.info(":: DataService -> getDataWithDelay: " + delay);

            var def = $q.defer();

            var data = [{
                name: 'Installation',
                data: [43934, 52503, 57177, 69658, 97031, 119931, 137133, 154175]
            }, {
                name: 'Manufacturing',
                data: [24916, 24064, 29742, 29851, 32490, 30282, 38121, 40434]
            }, {
                name: 'Sales & Distribution',
                data: [11744, 17722, 16005, 19771, 20185, 24377, 32147, 39387]
            }, {
                name: 'Project Development',
                data: [null, null, 7988, 12169, 15112, 22452, 34400, 34227]
            }, {
                name: 'Other',
                data: [12908, 5948, 8105, 11248, 8989, 11816, 18274, 18111]
            }];

            $timeout(function () {
                def.resolve(data);
            }, delay);

            return def.promise;
        };

    }]);
})(app);