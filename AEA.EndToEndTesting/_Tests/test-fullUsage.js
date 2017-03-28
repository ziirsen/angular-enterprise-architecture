var _siteUrl = 'http://site-b.local/';

function runTest(_browser) {
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

module.exports = {
    'Load-test: Single bundle application - User 1': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 2': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 3': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 4': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 5': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 6': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 7': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 8': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 9': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 10': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 11': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 12': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 13': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 14': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 15': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 16': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 17': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 18': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 19': function (browser) {
        runTest(browser)
          .end();
    },
    'Load-test: Single bundle application - User 20': function (browser) {
        runTest(browser)
          .end();
    },
};