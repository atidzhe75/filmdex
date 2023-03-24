@Code
    ViewData("Title") = "Home Page"
End Code
<link rel="stylesheet" href="~/Content/Logo-Moving.css">
<main>
   
   
    <div class="row">
        <section class="col-md-4" aria-labelledby="gettingStartedTitle">
            <div class="text-container">               
                <h1 style="text-align: center; font-size: 55px">WELCOME</h1>
                <h1 style="text-align: center; font-size: 55px">TO</h1>
                <h1 style="text-align: center; font-size: 55px">FILMDEX</h1>
                <style>
                    .text-container {
                        width: auto;
                        height: auto;
                        transform: translate(10px, calc(var(--circle-diameter) - 135px));
                        z-index: 3;
                        position: absolute;
                        left: 50% !important;
                        top: 56% !important;
                        transform: translate(-50%, -50%) !important;
                    }
                    h1 {
                       line-height: 60px!important;
                    }
                    </style>
            </div>

            <div class="logo-container">
                <div id="top-half-cover">
                    <div id="top-half" class="half-circle"></div>
                </div>
                <div id="bottom-half-cover">
                    <div id="bottom-half" class="half-circle"></div>
                </div>
            </div>
        </section>
    </div>
</main>
