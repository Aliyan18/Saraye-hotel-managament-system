
function cancelroom(item) {
        let txt1 = item.innerHTML;
   let button = document.createElement("button");
    //let button =;
    button.classList.add("btn");
      //  removeEventListener("dblclick", chooseRoom); //line added

        item.addEventListener("mouseover", () => {
            item.innerHTML = "Cancel<br>";

            item.appendChild(button);
            button.addEventListener("mousedown", () => {
                let t2 = document.querySelector("#t2");
                let num = '';
                for (let j = 0; txt1[j] >= 0 && txt1[j] <= 9; j++)
                    num += txt1[j];
                console.log(txt1);
                t2.value = num;
            })
        })
}
function chooseRoom(el) {
    if (!el.classList.contains("mystyle")) {
        console.log(el);
        document.querySelectorAll("#myDiv").forEach((element) => {
            if (element.classList.contains("mystyle") ) {
                element.classList.add("styl");
                element.classList.remove("mystyle");
                element.removeEventListener("mouseover", confirm);
            }


        });

        el.classList.remove("styl");
        el.classList.add("mystyle");

        let txt = el.innerHTML;
        let bttn = document.createElement("button");
        let bttn2 = document.createElement("button");
        //let bttn = document.querySelector("#btn1");

        function confirm() {
            el.innerHTML = "CONFIRM<br>";
            bttn.classList.add("btn");
            bttn2.classList.add("b", "btn");

            el.appendChild(bttn);
            el.appendChild(bttn2);
            bttn.addEventListener("mousedown", () => {
                let t1=document.querySelector("#t1");
                t1.value = "";
                let num = '';
                for (let j = 0; txt[j] >= 0 && txt[j] <= 9;j++)
                    num+=txt[j];
                t1.value = num;

              //  el.classList.remove("mystyle");
                // el.classList.add();
                let bttn3 = document.querySelector("#btn1");
                bttn3.addEventListener("mousedown", () => {
                    el.classList.remove("mystyle");
                    el.classList.add("booked");
                    el.removeChild(bttn);
                   el.appendChild(button);
                })
           /*     document.querySelector("body").addEventListener("mousedown", (event) => {
                    console.log(event.target);
                    if (event.target === bttn3) {
                        return; // If it is, do nothing
                    }
                    document.querySelector("#t1").value = "";
                    document.querySelector("#t2").value = "";

                 //   el.classList.add("styl");
                   // el.classList.remove("mystyle");
                    //el.removeEventListener("mouseover", confirm);
                    

                }); */
               
               
            });

        }
        confirm();
        el.addEventListener("mouseover", confirm);

      /*  el.addEventListener("mouseout", (event) => {
            if (!(event.target === bttn)) {
                const isChild = el.contains(event.relatedTarget); // Check if the related target is a child of the div
                el.innerHTML = txt;
                el.removeChild(bttn);
                el.removeChild(bttn2);
            }

        });*/

        document.querySelector("body").addEventListener("mousedown", (event) => {
            console.log(event.target);
            if (event.target === el) {
                return; // If it is, do nothing
            }
            el.innerHTML = txt;
       
            el.classList.add("styl");
            el.classList.remove("mystyle");
            el.removeEventListener("mouseover", confirm);
            console.log(event.target);

        });
    }
}
