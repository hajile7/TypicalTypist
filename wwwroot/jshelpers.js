let profilePageInstance;

function initializePopover() {
    const popoverTriggerList = document.querySelectorAll('[data-bs-toggle="popover"]');
    popoverTriggerList.forEach(function (popoverTriggerEl) {
        const content = `
            <div>
                <span class='popover-option' data-bs-option='a'>A </span>
                <span class='popover-option' data-bs-option='b'>B </span>
                <span class='popover-option' data-bs-option='c'>C </span>
                <span class='popover-option' data-bs-option='d'>D </span>
                <span class='popover-option' data-bs-option='e'>E </span>
                <span class='popover-option' data-bs-option='f'>F </span>
                <span class='popover-option' data-bs-option='g'>G </span>
                <span class='popover-option' data-bs-option='h'>H </span>
                <span class='popover-option' data-bs-option='i'>I </span>
                <span class='popover-option' data-bs-option='j'>J </span>
                <span class='popover-option' data-bs-option='k'>K </span>
                <span class='popover-option' data-bs-option='l'>L </span>
                <span class='popover-option' data-bs-option='m'>M </span>
                <span class='popover-option' data-bs-option='n'>N </span>
                <span class='popover-option' data-bs-option='o'>O </span>
                <span class='popover-option' data-bs-option='p'>P </span>
                <span class='popover-option' data-bs-option='q'>Q </span>
                <span class='popover-option' data-bs-option='r'>R </span>
                <span class='popover-option' data-bs-option='s'>S </span>
                <span class='popover-option' data-bs-option='t'>T </span>
                <span class='popover-option' data-bs-option='u'>U </span>
                <span class='popover-option' data-bs-option='v'>V </span>
                <span class='popover-option' data-bs-option='w'>W </span>
                <span class='popover-option' data-bs-option='x'>X </span>
                <span class='popover-option' data-bs-option='y'>Y </span>
                <span class='popover-option' data-bs-option='z'>Z </span>
            </div>
        `;

        const popoverInstance = new bootstrap.Popover(popoverTriggerEl, {
            html: true,
            content: content,
            sanitize: false
        });

        popoverTriggerEl.addEventListener('shown.bs.popover', function () {
            const popoverElement = document.querySelector('.popover');
            if (popoverElement) {
                popoverElement.addEventListener('click', function (event) {
                    const target = event.target;
                    if (target && target.classList.contains('popover-option')) {
                        const selectedOption = target.getAttribute('data-bs-option');
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
