# reusable-unity-ui

DOTween: https://assetstore.unity.com/packages...

Using animators for UI animation is a really bad idea. It is really bad for performance because when an animator is attached to a UI element, it dirties the whole canvas the UI element resides in (even when idle). Thus it issues a canvas rebuild causing the whole canvas to redraw again. It takes up valuable GPU and CPU time. 

A better way to do it is using DOTween. When idle tween does not issue canvas rebuilds, it does that only when an animation is taking place, which is fine.

We will turn each animation into an asset so that it is very easily extendable and can easily be reused across projects.
