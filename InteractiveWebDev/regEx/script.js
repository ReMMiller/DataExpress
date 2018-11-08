function validate(){
    var errors = false;
    var errorMessage = "";

    var fName = document.forms['MyForm']['fName'].value;
    var phone = document.forms['MyForm']['phone'].value;

    var name_pat = /[a-z]+/;
    var phone_pat = /(1?\([0-9]{3}\)( |)|(1-|1)?[0-9]{3}-?)[0-9]{3}-?[0-9]{4}/;

    //console.log(name_pat.test(fName));
    if(!name_pat.test(fName)){
        errors = true;
        errorMessage += "Not a valid First Name. <br />";
    }
    //console.log(phone_pat.test(phone));
    if(!phone_pat.test(phone)){
        errors = true;
        errorMessage += "Not a valid Phone Number. <br />";
    }

    if(errors){
        document.getElementById('response').innerHTML = errorMessage;
    } else{
        return true;
    }

    return false;
}