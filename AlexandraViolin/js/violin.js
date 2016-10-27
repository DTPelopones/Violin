$(document).ready(function () {
    var activeHeight = 450,
        navbar = $('.navbar'),
        navBrand = $('.navbar-brand'),
        navItem = $('.navbar-nav a'),
        padding = 9.5,
        fontSize = 16;
        
    $(window).scroll(function () {
        var screenWidth = $(window).width();
        if (screenWidth > 767) {
            var topHeight = activeHeight - $(document).scrollTop(),
                scale = topHeight / activeHeight,
                currPadding = padding,
                currFontSize = fontSize;

            if (scale > 0) {
                currPadding = (padding + (scale * 10)) + 'px';
                currFontSize = (fontSize + (scale * 2)) + 'px';
            }
            navItem.css({ 'padding-top': currPadding, 'padding-bottom': currPadding, 'font-size': currFontSize });
            navBrand.css({ 'padding-top': currPadding, 'padding-bottom': currPadding });
        }
    });

    $('#mediaTab a').click(function (e) {
        var href = $(this).attr('href');
        sessionStorage.setItem('activeTab', href);
    });
    
    if (sessionStorage.getItem('activeTab')) {
        var href = sessionStorage.getItem('activeTab');
        $('#mediaTab a[href="' + href + '"]').tab('show');
    }
});