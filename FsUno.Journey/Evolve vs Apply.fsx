(**
# Evolve vs Apply

*2016-08-25*

I definitely changed the name of the `apply` function to `evolve`.

The name `apply` implies too much mutability semantic, and is too much associated with replay.

I also renamed `replay` to `fold` for the same reason.

People tend to get scared of Event Sourcing because of this replay thing... I often hear people asking _Will side effects happen again ?_

Using the name `fold` implies it's a simple side-effect-free computation.

*)
