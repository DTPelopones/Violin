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
});