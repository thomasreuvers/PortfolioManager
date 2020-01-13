$(window).on("load", function() {

  // FADE OUT PRELOADER SCREEN //
    $('.preloader').fadeOut('slow');
    $('html, body').css({
      overflow: 'auto'});
  // END //

  var $nav = $(".navigation-bar");

  // Enable 'scrolled' class immediatly on page load if requirements met //
  if($(window).scrollTop() > 1){
    $nav.toggleClass('scrolled', $(this).scrollTop() > $nav.height());
  }
  // END //


  // Change navbar color on scroll //
  $(function () {
    $(document).scroll(function () {
      $nav.toggleClass('scrolled', $(this).scrollTop() > $nav.height());
    });
  });
  // END //


  // TOGGLE NAV MENU //
  $("#hamburger").click(function(){
    $("#hamburger").toggleClass("is-active");
    $(".menu-items").toggleClass("responsive-menu");
  });
  // END //


  // Cross-Browser Smooth Scroll //
  $("a").on('click', function(event) {

    if (this.hash !== "") {

      event.preventDefault();

      var hash = this.hash;

      $('html, body').animate({
        scrollTop: $(hash).offset().top
      }, 800, function(){

        window.location.hash = hash;
      });
    }
  });
  // END //


  // Morphext Settings //
  $("#js-rotating").Morphext({

  animation: "fadeIn",
  separator: ",",
  speed: 4000,
    complete: function () {
    }
  });
  // END //


  // Owl Carousel Settings
  $(".owl-carousel").owlCarousel({
    loop:true,
    nav:true,
    margin: 25,
    responsiveClass:true,
    responsive:{
        0:{
            items:1
        },
        600:{
            items:3
        },
        1000:{
            items:4
        }
    }
  });
  // END //


  // AOS Settings //
  AOS.init({
    once: true
  });
  // END //

});