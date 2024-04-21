// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var swiper = new Swiper(".mySwiper", {
    navigation: {
        nextEl: ".swiper-button-next",
        prevEl: ".swiper-button-prev",
    },
});

var swiper = new Swiper(".product-phone-swiper", {
    slidesPerView: 4,
    spaceBetween: 30,
    pagination: {
        el: "#mobile-phones .swiper-pagination",
        clickable: true,
    },
});

var swiper = new Swiper(".product-watch-swiper", {
    slidesPerView: 4,
    spaceBetween: 30,
    pagination: {
        el: "#smart-watches .swiper-pagination",
        clickable: true,
    },
});