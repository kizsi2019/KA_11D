var Entity = function(damage, health, speed){
    this.damage = damage;
    this.health = health;
    this.speed = speed
}

var player = new Entity(12, 100, 5);
console.log(player);