This project aims to show 2 easy principles you can apply when working with mono build of Godot. (saying "mono" isn't exactly right any more as it's now all .NET 6,7,8...)

## Principle 1

You can (and probably should) move as much logic away from your Godot project in a separate project. That project is named "Core.Project" in this repository. Not having a dependency on Godot enforces good practices and, if there's a need, allows you to move away from Godot entirely with as little hustle as possible.

## Principle 2

You can (and probably should) use GDScript for your UI code. All this while still using mono for the rest of your game! It is very close to the usual split we see in web development:

- SPA framework in the frontend (Vue, React, Angular...) is actually Godot and it uses GDScript instead of Javascript
- A robust language in the backend is C#

Similarly to Principle 1, it forces you to split your logic away from your presentation. Keep in mind this introduces some overhead and is more useful for management-heavy games. Think Crusader Kings, Football Manager, Civilization...

These ideas I've developed and validated over the two years I was working on Master of Chess: https://store.steampowered.com/app/2248900/Master_of_Chess/
If anything is unclear, I can be reached on my discord channel: https://discord.gg/HYV8Zz8V2Q
