function showModal() 
{
    document.getElementById("modal").style.display = "block";
    document.getElementById("overlay").style.display = "block";
    document.body.classList.add('no-scroll');
    document.documentElement.classList.add('no-scroll');
}

function closeModal() 
{
    document.getElementById("modal").style.display = "none";
    document.getElementById("overlay").style.display = "none";
    document.body.classList.remove('no-scroll');
    document.documentElement.classList.remove('no-scroll');
}