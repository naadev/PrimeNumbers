const { Given, Then, When } = require('cucumber');
const expect = require('chai').expect;
const DetectPrimeNumber = require('../../app.js').DetectPrimeNumber;

var number
Given('a number {string}', function (theNumber) {
    number = theNumber;
});

var isPrimerOrNot;
When('I check whether is prime or not', function () {

    isPrimerOrNot = DetectPrimeNumber(number);
});


Then('the operation result shall be {string}', function (trueOrFalse) {
    console.log(trueOrFalse + ' ' + isPrimerOrNot + ' ' + (isPrimerOrNot == trueOrFalse));
    var isTrueOrFalse = (trueOrFalse == 'true')
    expect(isPrimerOrNot).to.be.equal(isTrueOrFalse);
});