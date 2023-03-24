const btn1 = document.querySelector('#green');
const btn2 = document.querySelector('#red');

const likeStatus = localStorage.getItem('like-status');
if (likeStatus) {
    if (likeStatus === 'liked') {
        btn1.classList.add('green');
    }
    if (likeStatus === 'disliked') {
        btn2.classList.add('red');
    }
}

btn1.addEventListener('click', () => {
    setButtonColorAndAddToLocalStorage(btn1, 'green', btn2, 'red', 'liked');
});

btn2.addEventListener('click', () => {
    setButtonColorAndAddToLocalStorage(btn2, 'red', btn1, 'green', 'disliked');
});

setButtonColorAndAddToLocalStorage = (elm, elmClass, altElm, altElmClass, status) => {
    const elmStatusSet = elm.classList.contains(elmClass);
    elm.classList.toggle(elmClass);
    altElm.classList.remove(altElmClass);
    localStorage.setItem('like-status', elmStatusSet ? '' : status);
};

