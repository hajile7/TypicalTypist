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

window.addEscKeyListener = function (dotNetObject) {
    if (!window.escKeyListener) {
        window.escKeyListener = (event) => {
            if (event.key === "Escape") { 
                dotNetObject.invokeMethodAsync('OnEscKeyUp');
            }
        };
        window.addEventListener('keyup', window.escKeyListener);
    }
};

window.removeEscKeyListener = function () {
    if (window.escKeyListener) {
        window.removeEventListener('keyup', window.escKeyListener);
        window.escKeyListener = null;
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