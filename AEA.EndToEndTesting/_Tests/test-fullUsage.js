var _siteUrl = 'http://load-test-a.crator.dk/';

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

var tests = {},
    amount = 1000;

// Create tests
for (var i = 0, len = amount; i < len; i++) {
    tests['Load-test: Single bundle - User ' + (i + 1)] = function (browser) {
        runTest(browser)
            .end();
    }
}

// Apply tests
module.exports = tests;