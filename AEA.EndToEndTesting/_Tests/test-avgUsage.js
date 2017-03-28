var _siteUrl = 'http://site-a.local/';

function runTestFullUsage(_browser) {
    return _browser
         .url(_siteUrl)
         .waitForElementVisible('body', 1000)
         .waitForElementVisible('a[id=btn-home]', 1000)

           // Page 1
         .click('a[id=btn-home]')
         .pause(1000)
         .assert.containsText('h1', 'Angular Boilerplate')

           // Page 2
         .click('a[id=btn-dashboard]')
         .pause(1000)
         .assert.containsText('h1', 'Headline 1')

           // Page 3
         .click('a[id=btn-contact]')
         .pause(1000)
         .assert.containsText('h1', 'Contact us today')

           // Page 4
         .click('a[id=btn-chart]')
         .pause(1000)
         .assert.containsText('h1', 'Charting it out')
}

function runTestMinimalUsage(_browser) {
    return _browser
         .url(_siteUrl)
         .waitForElementVisible('body', 1000)
         .waitForElementVisible('a[id=btn-home]', 1000)

           // Page 1
         .click('a[id=btn-home]')
         .pause(1000)
         .assert.containsText('h1', 'Angular Boilerplate')

           // Page 2
         .click('a[id=btn-contact]')
         .pause(1000)
         .assert.containsText('h1', 'Contact us today')
}

function runTestPrimaryUsage(_browser) {
    return _browser
         .url(_siteUrl)
         .waitForElementVisible('body', 1000)
         .waitForElementVisible('a[id=btn-home]', 1000)

           // Page 1
         .click('a[id=btn-home]')
         .pause(1000)
         .assert.containsText('h1', 'Angular Boilerplate')

            // Page 2
         .click('a[id=btn-dashboard]')
         .pause(1000)
         .assert.containsText('h1', 'Headline 1')

           // Page 3
         .click('a[id=btn-contact]')
         .pause(1000)
         .assert.containsText('h1', 'Contact us today')
}

module.exports = {
    // Full load
    'Load-test: Runtime inject application - User 1': function (browser) {
        runTestFullUsage(browser)
          .end();
    },
    'Load-test: Runtime inject application - User 2': function (browser) {
        runTestFullUsage(browser)
          .end();
    },
    'Load-test: Runtime inject application - User 3': function (browser) {
        runTestFullUsage(browser)
          .end();
    },
    'Load-test: Runtime inject application - User 4': function (browser) {
        runTestFullUsage(browser)
          .end();
    },
    'Load-test: Runtime inject application - User 5': function (browser) {
        runTestFullUsage(browser)
          .end();
    },
    'Load-test: Runtime inject application - User 6': function (browser) {
        runTestFullUsage(browser)
          .end();
    },

    // Primary
    'Load-test: Runtime inject application - User 7': function (browser) {
        runTestPrimaryUsage(browser)
          .end();
    },
    'Load-test: Runtime inject application - User 8': function (browser) {
        runTestPrimaryUsage(browser)
          .end();
    },    
    'Load-test: Runtime inject application - User 9': function (browser) {
        runTestPrimaryUsage(browser)
          .end();
    },
    'Load-test: Runtime inject application - User 10': function (browser) {
        runTestPrimaryUsage(browser)
          .end();
    },

    // Minimal
    'Load-test: Runtime inject application - User 11': function (browser) {
        runTestMinimalUsage(browser)
          .end();
    },
    'Load-test: Runtime inject application - User 12': function (browser) {
        runTestMinimalUsage(browser)
          .end();
    },
    'Load-test: Runtime inject application - User 13': function (browser) {
        runTestMinimalUsage(browser)
          .end();
    },
    'Load-test: Runtime inject application - User 14': function (browser) {
        runTestMinimalUsage(browser)
          .end();
    },
    'Load-test: Runtime inject application - User 15': function (browser) {
        runTestMinimalUsage(browser)
          .end();
    },
    'Load-test: Runtime inject application - User 16': function (browser) {
        runTestMinimalUsage(browser)
          .end();
    },
    'Load-test: Runtime inject application - User 17': function (browser) {
        runTestMinimalUsage(browser)
          .end();
    },
    'Load-test: Runtime inject application - User 18': function (browser) {
        runTestMinimalUsage(browser)
          .end();
    },
    'Load-test: Runtime inject application - User 19': function (browser) {
        runTestMinimalUsage(browser)
          .end();
    },
    'Load-test: Runtime inject application - User 20': function (browser) {
        runTestMinimalUsage(browser)
          .end();
    }
};