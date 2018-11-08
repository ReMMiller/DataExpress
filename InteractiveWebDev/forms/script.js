function validate() {
    var errors = false;
    var error_msg = "";
    
    var verified = false;

    var states = [ 'AL', 'AK', 'AS', 'AZ', 'AR', 'CA', 'CO', 'CT', 'DE', 'DC', 'FM', 'FL', 'GA', 'GU', 'HI', 'ID', 'IL', 'IN', 'IA', 
    'KS', 'KY', 'LA', 'ME', 'MH', 'MD', 'MA', 'MI', 'MN', 'MS', 'MO', 'MT', 'NE', 'NV', 'NH', 'NJ', 'NM', 'NY', 'NC', 'ND', 'MP', 'OH', 
    'OK', 'OR', 'PW', 'PA', 'PR', 'RI', 'SC', 'SD', 'TN', 'TX', 'UT', 'VT', 'VI', 'VA', 'WA', 'WV', 'WI', 'WY' ];

    var fname = document.forms['myForm']['fname'].value;
    var lname = document.forms['myForm']['lname'].value;
    var password = document.forms['myForm']['password'].value;
    var address = document.forms['myForm']['address'].value;
    var city = document.forms['myForm']['city'].value;
    var state = document.forms['myForm']['state'].value;
    var phone = document.forms['myForm']['phone'].value;
    var zip = document.forms['myForm']['zip'].value;
    var confirm = document.forms['myForm']['password2'].value;
    /////////////////////////////////////////////////////////////////////////////////////

    var fname_patt = /[a-z]{2,}/i;
    var lname_patt = /[a-z]{2,}/i;
    var address_patt = /([a-z]|[0-9]){2,}[\s][a-z|0-9]+/i;
    var city_patt = /[a-z]{2,}/;
    var zip_patt = /^[0-9]{5}(?:-[0-9]{4})?$/;
    var pass_patt = /(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{8,})/;

    var state_bool = false;
    for(var x = 0; x <states.length; x++){
        if(states[x] === state.toUpperCase()){
            state_bool = true;
        }
    }
    
    var phone_patt = /(1?\([0-9]{3}\)( |)|(1-|1)?[0-9]{3}-?)[0-9]{3}-?[0-9]{4}/;


    /////////////////////////////////////////////////////////////////////////////////////


    //////////////////////////////////////////////////////////////////////////////////////

    if(fname===null || fname===""){
        errors = true;
        error_msg += "Not a valid entry. All spaces must be filled.<br />";
    }
    if(!fname_patt.test(fname)) {
        errors = true;
        error_msg += "Not a valid first name. First name must have at least one letter.<br />";
    }
    if(!lname_patt.test(lname)) {
        errors = true;
        error_msg += "Not a valid last name. Last name must have at least one letter.<br />";
    }
    if(!address_patt.test(address)) {
        errors = true;
        error_msg += "Not a valid address. Valid address must have at least one character, followed by a space and at least one or more other characters<br />";
    }
    if(!city_patt.test(city)) {
        errors = true;
        error_msg += "Not a valid city. Valid city must be longer than one character.<br />";
    }
    if(!state_bool) {
        errors = true;
        error_msg += "Not a valid state. Valid state code is two character valid US state code.<br />";
    }
    if(!zip_patt.test(zip)) {
        errors = true;
        error_msg += "Not a valid zip code.Valid codes in xxxxx and xxxxx-xxxx.<br />";
    }
    if(!phone_patt.test(phone)) {
        errors = true;
        error_msg += "Not a valid phone number. Valid formats: 1111111111 or 1(111)111-1111 or 1(111) 111-1111 or (111)111-1111 or 111-111-1111.<br />";
    }
    if(!pass_patt.test(password)) {
        errors = true;
        error_msg += "Not a valid password. Password must be at least 8 characters and include one capitalized letter, one digit, and one special character .<br />";
    }
    if(confirm !== password) {
        errors = true;
        error_msg += "Not a valid password. Passwords must match.<br />";
    }
    ///////////////////////////////////////////////////////////////

    
    if(errors) {
        document.getElementById('response').innerHTML = error_msg;
        return false;
    }
    else {
        return true;
    }
}