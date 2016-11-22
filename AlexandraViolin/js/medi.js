/* Video */
/*var tag = document.createElement('script');

tag.src = "https://www.youtube.com/iframe_api";
var firstScriptTag = document.getElementsByTagName('script')[0];
firstScriptTag.parentNode.insertBefore(tag, firstScriptTag);

document.addEventListener('DOMContentLoaded',
    function () {
        var div, n,
            v = document.getElementsByClassName('youtube');
        for (n = 0; n < v.length; n++) {
            div = document.createElement('div');
            div.setAttribute('data-id', v[n].dataset.id);
            div.innerHTML = labnolThumb(v[n].dataset.id);
            div.onclick = labnolIframe;
            v[n].appendChild(div);
        }
    });

function labnolThumb(id) {
    var thumb = '<img src="https://i.ytimg.com/vi/ID/hqdefault.jpg">',
        play = '<div class="play"></div>';
    return thumb.replace('ID', id) + play;
}

function labnolIframe() {
    var iframe = document.createElement('iframe'),
        id = document.getElementsByClassName('yt_players').length;
    iframe.setAttribute('src', "https://www.youtube.com/embed/" + this.dataset.id + "?autoplay=1&rel=0&enablejsapi=1");
    iframe.setAttribute('frameborder', '0');
    iframe.setAttribute('allowfullscreen', '');
    iframe.classList.add('yt_players');
    iframe.setAttribute('id', 'youtube' + id);
    this.parentNode.replaceChild(iframe, this);
    onYouTubeIframeAPIReady();
}

function onYouTubeIframeAPIReady() {
    var temp = $('iframe.yt_players');
    for (var i = 0; i < temp.length; i++) {
        new YT.Player($(temp[i]).attr('id'), {
            events: {
                'onStateChange': onPlayerStateChange
            }
        });
    }
}

var activePlayer;
function onPlayerStateChange(event) {
    if (event.data == YT.PlayerState.PLAYING) {
        if (activePlayer && activePlayer != event.target) {
            activePlayer.pauseVideo();
        }
        activePlayer = event.target;
    }
}*/

// Tabs
$(document).ready(function () {
    
    $('#mediaTab a').click(function (e) {
        var href = $(this).attr('href');
        sessionStorage.setItem('activeTab', href);
    });
    
    if (sessionStorage.getItem('activeTab')) {
        var href = sessionStorage.getItem('activeTab');
        $('#mediaTab a[href="' + href + '"]').tab('show');
    }
    
    /* Audio */
    var activeAudio;
    $('audio').on('play', function () {
        if (activeAudio && activeAudio != this) {
            activeAudio.pause();
        }
        activeAudio = this;
    });

    /*var init_player;
    $('#mediaTab a[href="#Video"]').click(function (e) {
        if (!init_player) {
            setTimeout(initPlayer, 150);
            init_player = true;
        }
    });

    //$('#mediaTab a').click(function (e) {
    //    var href = $(this).attr('href');
    //    sessionStorage.setItem('activeTab', href);
    //});

    if (sessionStorage.getItem('activeTab')) {
        var href = sessionStorage.getItem('activeTab');
        //$('#mediaTab a[href="' + href + '"]').tab('show');
        if (href == '#Video') {
            setTimeout(initPlayer, 150);
            init_player = true;
        }
    }*/
});

//function initPlayer() {
    var type = ($(document).width() > 991) ? 'vertical' : 'horizontal';
    $('#video_player').youtube_video({
        playlist: 'PLC6V-5RHrLMe7_GYbXrgVrv_KLdFhb1-8', //'',PLWz5rJ2EKKc8jQTUYvIfqA9lMvSGQWtte
        max_results: 10,
        force_hd: true,
        playlist_type: type,
        share_control: false,
        youtube_link_control: false,
        hide_youtube_logo: true,
        now_playing_text: 'Воспроизводится',
        load_more_text: 'Ещё...',
        mute_off_title: 'Включить звук',
        mute_on_title: 'Отключение звука',
        share_title: 'Поделиться',
        open_in_youtube_title: 'Смотреть это видео на youtube.com',
        prev_video_title: 'Предыдущее видео',
        next_video_title: 'Следующее видео',
        hide_playlist_title: 'Скрыть плэйлист',
        show_playlist_title: 'Показать плэйлист',
        enter_fullscreen_title: 'Во весь экран',
        exit_fullscreen_title: 'Выход из полноэкранного режима'
    });

    $('.yesp-icon[class*="yesp-icon-"]').each(function () {
        $(this).addClass('material-icons');
        $(this).not('.yesp-icon-play').powerTip({
            smartPlacement: true
        });
    });

    $('.yesp-icon[class*="yesp-icon-"]').on({
        powerTipPreRender: function () {
            // generate some dynamic content
            $(this).data('powertip', $(this).data('title'));
        }
    });

    $('.yesp-icon[class*="yesp-icon-"]').not('.yesp-icon-play').on('click', function () {
        $.powerTip.hide();
        $.powerTip.show(this);
    });
//}