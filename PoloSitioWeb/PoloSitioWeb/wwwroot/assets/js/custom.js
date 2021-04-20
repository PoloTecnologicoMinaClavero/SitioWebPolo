new Swiper('.enterprises-slider', {
    speed: 600,
    loop: true,
    autoplay: {
        delay: 12000,
        disableOnInteraction: false
    },
    slidesPerView: 'auto',
    pagination: {
        el: '.swiper-pagination',
        type: 'bullets',
        clickable: true
    },
    breakpoints: {
        320: {
            slidesPerView: 1,
            spaceBetween: 40
        },

        1200: {
            slidesPerView: 3,
            spaceBetween: 40
        }
    }
});

new Swiper('.sponsors-slider', {
    speed: 600,
    loop: false,
    autoplay: {
        delay: 12000,
        disableOnInteraction: false
    },
    slidesPerView: 'auto',
    pagination: {
        el: '.swiper-pagination',
        type: 'bullets',
        clickable: true
    },
    breakpoints: {
        320: {
            slidesPerView: 1,
            spaceBetween: 40
        },

        1200: {
            slidesPerView: 1,
            spaceBetween: 40
        }
    }
});