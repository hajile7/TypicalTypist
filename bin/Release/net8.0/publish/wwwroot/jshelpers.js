window.globalKeyListener = {
    add: function (dotNetHelper) {
        document.addEventListener('keydown', function (event) {
            dotNetHelper.invokeMethodAsync('HandleKeydown', event.key);
        });
    },
    remove: function () {
        document.removeEventListener('keydown', () => {});
    }
};