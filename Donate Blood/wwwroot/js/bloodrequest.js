function redirectToDetails(id){
        if(id != null){
            window.location.href = `/BloodRequests/BloodRequestDetails/${id}`;
        } 
}

function redirectToReqSender(id){
    if(id != null){
        window.location.href = `/SearchDonors/DonorDetails/?userId=${id}`;
    } 
}

function deletePost(id){
    console.log(id);
    if(id != "" || undefined){
    let xhr = new XMLHttpRequest();
    xhr.open("DELETE",`/MyProfile/DeletePost/?Id=${id}`);
    xhr.setRequestHeader('Content-type','application/json; charset=utf-8');
    xhr.onload = function (){
        if(xhr.readyState == 4 && xhr.status == 200){
            if(this.responseText == "success"){
                window.location.reload();
            }
        }
       }

    xhr.send(null);

    }
    

}





