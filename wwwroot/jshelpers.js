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

function scrollTypingContainer() {
    if (event.key === ' ' && document.activeElement === document.querySelector('.noFocusVisible')) {
        event.preventDefault();
    }
    const typingContainer = document.querySelector('.typing-container');
    const cursor = document.querySelector('.cursor');

    if (cursor) {
        const cursorRect = cursor.getBoundingClientRect();
        const containerRect = typingContainer.getBoundingClientRect();

        if (cursorRect.bottom > containerRect.bottom - 50) {
            typingContainer.scrollTop += 50; 
            console.log('I scrolled!')
        }
    }
}
function addSpacePreventListener() {
    document.addEventListener('keydown', function(event) {
        if (event.key === ' ' && document.activeElement === document.querySelector('.noFocusVisible')) {
            console.log('Space scroll prevented');
            event.preventDefault();
            event.stopPropagation();
        }
    }, { capture: true });
}