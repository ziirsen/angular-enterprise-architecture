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

var tests = {},
    amountFullLoad = 2,
    amountNormalLoad = 5,
    amountMinimalLoad = 8;

// Create tests
for (var i = 0, len = amountFullLoad; i < len; i++) {
    tests['Load-test: Runtime inject full - User ' + (i + 1)] = function (browser) {
        runTestFullUsage(browser)
            .end();
    }
}

for (var i = 0, len = amountNormalLoad; i < len; i++) {
    tests['Load-test: Runtime inject normal - User ' + (i + 1)] = function (browser) {
        runTestPrimaryUsage(browser)
            .end();
    }
}

for (var i = 0, len = amountMinimalLoad; i < len; i++) {
    tests['Load-test: Runtime inject minimal - User ' + (i + 1)] = function (browser) {
        runTestMinimalUsage(browser)
            .end();
    }
}

// Apply tests
module.exports = tests;