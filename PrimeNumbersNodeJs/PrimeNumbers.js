'use strict';


function DetectPrimeNumber(number) {
    for (let i = 2; i < number; i++)
    {
        if (number % i == 0) {
            return false;
        }
    }
    return true;

}

exports.DetectPrimeNumber = DetectPrimeNumber 