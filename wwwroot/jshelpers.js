window.addGlobalKeyListener = function (dotNetObject) {
    if (!window.globalKeyListener) {
        window.globalKeyListener = (event) => {
            dotNetObject.invokeMethodAsync('OnKeyUp');
        };
        window.addEventListener('keyup', window.globalKeyListener);
    }
};

window.removeGlobalKeyListener = function () {
    if (window.globalKeyListener) {
        window.removeEventListener('keyup', window.globalKeyListener);
        window.globalKeyListener = null;
    }
};

function scrollTypingContainer() {
    setTimeout(() => {
        const typingContainer = document.querySelector('.typing-container');
        const cursor = document.querySelector('.cursor');

        if (cursor) {
            const cursorRect = cursor.getBoundingClientRect();
            const containerRect = typingContainer.getBoundingClientRect();

            if (cursorRect.bottom > containerRect.bottom - 50) {
                typingContainer.scrollTop += 50; 
            }

            if (cursorRect.top < containerRect.top + 50) {
                typingContainer.scrollTop -= 50;
            }
        }
    }, 1);
}

function addSpacePreventListener() {
    document.addEventListener('keydown', function(event) {
        if (event.key === ' ' && document.activeElement === document.querySelector('.no-focus-visible')) {
            console.log('Space scroll prevented');
            event.preventDefault();
            event.stopPropagation();
        }
    }, { capture: true });
}