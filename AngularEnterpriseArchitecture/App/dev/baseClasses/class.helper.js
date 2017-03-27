'use strict';

(function (ag) {
    ag.service('ClassHelper', [function () {
       
        this.Inherit = function (newClass, baseClass) {
            var _prototype = Object(baseClass.prototype);
            _prototype.constructor = newClass;
            newClass.prototype = _prototype;
        };

    }]);
})(app);
