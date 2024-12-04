let profilePageInstance;

function initializePopover() {
    const popoverTriggerList = document.querySelectorAll('[data-bs-toggle="popover"]');
    popoverTriggerList.forEach(function (popoverTriggerEl) {
        const content = `
            <div id='popoverContent'>
                <span class='popover-option' data-option='a'>A </span>
                <span class='popover-option' data-option='b'>B </span>
                <span class='popover-option' data-option='c'>C </span>
                <span class='popover-option' data-option='d'>D </span>
                <span class='popover-option' data-option='e'>E </span>
                <span class='popover-option' data-option='f'>F </span>
                <span class='popover-option' data-option='g'>G </span>
                <span class='popover-option' data-option='h'>H </span>
                <span class='popover-option' data-option='i'>I </span>
                <span class='popover-option' data-option='j'>J </span>
                <span class='popover-option' data-option='k'>K </span>
                <span class='popover-option' data-option='l'>L </span>
                <span class='popover-option' data-option='m'>M </span>
                <span class='popover-option' data-option='n'>N </span>
                <span class='popover-option' data-option='o'>O </span>
                <span class='popover-option' data-option='p'>P </span>
                <span class='popover-option' data-option='q'>Q </span>
                <span class='popover-option' data-option='r'>R </span>
                <span class='popover-option' data-option='s'>S </span>
                <span class='popover-option' data-option='t'>T </span>
                <span class='popover-option' data-option='u'>U </span>
                <span class='popover-option' data-option='v'>V </span>
                <span class='popover-option' data-option='w'>W </span>
                <span class='popover-option' data-option='x'>X </span>
                <span class='popover-option' data-option='y'>Y </span>
                <span class='popover-option' data-option='z'>Z </span>
            </div>
        `;

        const popoverInstance = new bootstrap.Popover(popoverTriggerEl, {
            html: true,
            content: content,
        });

        popoverTriggerEl.addEventListener('shown.bs.popover', function () {
            const popoverElement = document.querySelector('.popover');
            if (popoverElement) {
                popoverElement.addEventListener('click', function (event) {
                    const target = event.target;
                    if (target && target.classList.contains('popover-option')) {
                        const selectedOption = target.getAttribute('data-option');
                        console.log('Selected option:', selectedOption);

                        if (profilePageInstance) {
                            profilePageInstance.invokeMethodAsync('HandlePopoverOption', selectedOption);
                        } else {
                            console.error('Profile page instance not registered.');
                        }
                    }
                });
            }
        });
    });
}

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

function registerProfilePage(dotNetRef) {
    profilePageInstance = dotNetRef;
}

function unregisterProfilePage() {
    profilePageInstance = null;
}
