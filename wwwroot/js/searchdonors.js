let regionInput = document.querySelector(".region__input");


document.addEventListener("DOMContentLoaded",() =>{
    regionInput.addEventListener("input",(event) =>{
        console.log(event.target.value);
    });
    

});


