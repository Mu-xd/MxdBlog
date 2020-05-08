var app = new Vue({
    el: '#app',
    data:{
        activeIndex: '2',
        activeIndex2: '1'
    },
    methods: {
        handleSelect(key, keyPath) {
            console.log(key, keyPath);
        }
    }
});
