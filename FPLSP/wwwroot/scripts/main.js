(function ($) {
    "use strict";

  
    // Back to top button
    $(window).scroll(function () {
        if ($(this).scrollTop() > 300) {
            $('.back-to-top').fadeIn('slow');
        } else {
            $('.back-to-top').fadeOut('slow');
        }
    });
    $('.back-to-top').click(function () {
        $('html, body').animate({scrollTop: 0}, 1500, 'easeInOutExpo');
        return false;
    });


    // Sidebar Toggler
    $('.sidebar-toggler').click(function () {
        $('.sidebar, .content').toggleClass("open");
        return false;
    });
    $(".nav-item").click(function () {
        $(".nav-item").removeClass("active"); // This will remove active classes from all <li> tags
        $(this).addClass("active"); // This will add active class in clicked <li>   
    });

})(jQuery);

