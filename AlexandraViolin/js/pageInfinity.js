var pageNo = 1;
var isPageLoad = true;

$(window).scroll(function () {
        if($(window).scrollTop() == $(document).height() - $(window).height())
        {

            if (isPageLoad) {
                var alb = ViewBag.album;
                alert(ViewBag.album);
                $.ajax({
                    url: 'Photo',
                    data: { 'page': pageNo, 'album': alb },
                    success: function (data) {
                        $('#photopart').append(data);
                        pageNo++;
                        $("#loadPartPhoto").hide();
                        if ($.trim(data) == '' || $(data) == null) {
                            isPageLoad = false;
                        }
                    }
                });

            }
        }
    });