var ödön = {
    name: "Ödön",
    age: 45,
    work: 'csillagász',
    greeting: function(style, day){
        if(style === "official"){
            console.log("Üdvözlöm, jó " + day + " kívánok! " + this.name + " vagyok.");
        }else if (style === "friendly"){
            console.log("Szia, jó " + day + "!");
        }
    }
}
ödön.greeting("official", "hajnalt");
ödön.greeting("friendly", "estét")

var béla = {
    name: "Béla",
    age: 62,
    work: "portás"
}
ödön.greeting.call(béla, "friendly", "estét");
ödön.greeting.apply(béla, ["friendly", "reggelt"]);
var ödönFriendly = ödön.greeting.bind(ödön, "friendly");
ödönFriendly("napot");
ödönFriendly("estét");

var bélaOfficial = ödön.greeting.bind(béla, "official");
var bélaOfficialMorning = ödön.greeting.bind(béla, "official", "reggelt");
bélaOfficial("estét");
bélaOfficialMorning();
