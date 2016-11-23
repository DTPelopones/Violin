$(document).ready(function () {
    var activeHeight = 450,
        navBrand = $('.navbar-brand'),
        navItem = $('.navbar-nav a'),
        padding = 9.5,
        fontSize = 16;
        
    $(window).scroll(function () {
        var screenWidth = $(window).width();
        if (screenWidth > 991) {
            var topHeight = activeHeight - $(document).scrollTop(),
                scale = topHeight / activeHeight,
                currPadding = padding,
                currFontSize = fontSize;

            if (scale > 0) {
                currPadding = (padding + (scale * 10)) + 'px';
                if (screenWidth > 991) {
                    currFontSize = (fontSize + (scale * 2)) + 'px';
                }
            }
            navItem.css({ 'padding-top': currPadding, 'padding-bottom': currPadding, 'font-size': currFontSize });
            navBrand.css({ 'padding-top': currPadding, 'padding-bottom': currPadding });
        }
    });
});