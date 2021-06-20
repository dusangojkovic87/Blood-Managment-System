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





