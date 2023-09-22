import pygame
import random

# Initialize Pygame
pygame.init()

# Set up the game window
width, height = 1280, 1040
window = pygame.display.set_mode((width, height))
pygame.display.set_caption("Striker")

# Colors
BLACK = (1, 1, 2)
WHITE = (255, 255, 255)

# Player
player_image = pygame.image.load("space-ship.png")
player_rect = player_image.get_rect()
player_rect.centerx = width // 2
player_rect.bottom = height - 1
player_speed = 5

# Enemies
enemy_image = pygame.image.load("enemy.jpg")
enemies = []
num_enemies = 10
enemy_speed = 2  # Adjust the enemy speed as desired

for i in range(num_enemies):
    enemy_rect = enemy_image.get_rect()
    enemy_rect.x = random.randint(50, width - 50)
    enemy_rect.y = random.randint(10, 200)
    enemies.append(enemy_rect)

# Bullets
bullet_image = pygame.image.load("bullet.png")
bullet_rect = bullet_image.get_rect()
bullet_speed = 8
bullet_state = "ready"

# Game Loop
running = True
clock = pygame.time.Clock()

while running:
    # Handle events
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False

        # Player controls
        if event.type == pygame.KEYDOWN:
            if event.key == pygame.K_LEFT:
                player_rect.x -= player_speed
            if event.key == pygame.K_RIGHT:
                player_rect.x += player_speed
            if event.key == pygame.K_SPACE:
                if bullet_state == "ready":
                    bullet_rect.x = player_rect.x + player_rect.width // 2 - bullet_rect.width // 2
                    bullet_rect.y = player_rect.y - bullet_rect.height
                    bullet_state = "fire"

    # Update game objects
    for enemy in enemies:
        enemy.x += enemy_speed
    for enemy in enemies:
        enemy.y += 30

        # Collision detection
        if bullet_state == "fire" and bullet_rect.colliderect(enemy):
            bullet_state = "ready"
            bullet_rect.y = player_rect.y - bullet_rect.height
            enemy.x = random.randint(50, width - 50)
            enemy.y = random.randint(10, 200)
