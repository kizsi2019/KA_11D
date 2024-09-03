function kepcsere() {
    
    var img1 = document.getElementById('cat');
    var img2 = document.getElementById('dog');

    var tempSrc = img1.src;

    img1.src = img2.src;

    img2.src = tempSrc;
}
