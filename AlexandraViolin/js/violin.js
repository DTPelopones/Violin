var navigation = document.querySelector('.navbar'),
	pageHeight = document.documentElement.scrollHeight,
	offsetWidth = document.documentElement.offsetWidth,
	viewportHeight = document.documentElement.clientHeight;

window.onscroll = function () {
    var scrollTop = document.documentElement.scrollTop || document.body.scrollTop,
        widthLarge = offsetWidth >= 1200 || false;
    /*
    if ((scrollTop >= (viewportHeight / 2)) && widthLarge) {
        navigation.classList.add("navbar-small");
    }
    */
    if (scrollTop >= (viewportHeight - 500) && widthLarge) {
        navigation.classList.add("navbar-small");
    }
    if (scrollTop < (viewportHeight - 500) && widthLarge) {
        navigation.classList.remove("navbar-small");
    }
}