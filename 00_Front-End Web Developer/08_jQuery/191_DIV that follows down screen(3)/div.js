$(document).ready(function(){
   var current_top = parseInt($('#follow').css('top'));
    $('#follow').fadeIn(1000).click(function(){
      (this).fadeOut(1000);
   });

    $(window).scroll(function(){
          var top = $(window).scrollTop();
          $('#follow').css('top', top + current_top);
    });
});