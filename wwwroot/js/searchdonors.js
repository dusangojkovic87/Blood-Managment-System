document.addEventListener("DOMContentLoaded", () => {
  let messageToDonor = document.querySelector("#MessageToDonor");
  let sendBtn = document.querySelector(".send__msg__btn");
  let modal = document.querySelector("#messageModal");
  let closeModalBtn = document.querySelector("#closeMsgModal");
  let donorId = document.querySelector("#donorId");
  let senderName = document.querySelector("#senderName");
  let modalStatusText = document.querySelector(".modal__status__text");
  
  if (sendBtn != null) {
    sendBtn.addEventListener("click", (event) => {
      event.preventDefault();

      let data = { 
          "message": messageToDonor.value,
          "donorId":donorId.value,
          "senderName":senderName.value
     };

      let xhr = new XMLHttpRequest();
      xhr.open("POST", "/SearchDonors/Message");
      xhr.setRequestHeader("Content-Type", "application/json");
      xhr.onreadystatechange = function () {
        if (this.readyState === XMLHttpRequest.DONE && this.status === 200) {
          modalStatusText.innerHTML = this.responseText;
          modal.className = "modal-open";
          console.log(data);
          messageToDonor.value = "";
        }
      };
      xhr.send(JSON.stringify(data));
    });
  }

  if(closeModalBtn != null){
    closeModalBtn.addEventListener("click",() =>{
       modal.className = "close-message-modal";
    });
  }


});
