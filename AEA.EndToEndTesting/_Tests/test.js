module.exports = {
    'Can load chart page': function (browser) {
        browser
          .url('http://localhost:22400/')
          .waitForElementVisible('body', 1000)
          .waitForElementVisible('a[id=btn-chart]', 1000)
          .click('a[id=btn-chart]')
          .pause(1000)
          .assert.containsText('h1', 'Charting it out')
          .end();
    }
};