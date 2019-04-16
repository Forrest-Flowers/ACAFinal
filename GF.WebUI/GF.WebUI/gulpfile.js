const sass = require('gulp-sass');
function MyFunction(cb)
{
    console.log('My first task');

    cb();
}

exports.default = MyFunction;