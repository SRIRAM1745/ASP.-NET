function myFunction()
         {
            var dots = document.getElementById("dots");
            var moreText = document.getElementById("more");
            var btnText = document.getElementById("myBtn");

            if (dots.style.display === "none") 
            {
                dots.style.display = "inline";
                btnText.innerHTML = "Click here to view full article";
                moreText.style.display = "none";
            } 
            else
            {
                dots.style.display = "none";
                btnText.innerHTML = "Click here to view less article";
                moreText.style.display = "inline";
            }
        }
   