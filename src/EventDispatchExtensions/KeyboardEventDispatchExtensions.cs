﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom;
using Microsoft.AspNetCore.Components.Web;

namespace Egil.RazorComponents.Testing.EventDispatchExtensions
{
    /// <summary>
    /// Keyboard event dispatch helper extension methods.
    /// </summary>
    public static class KeyboardEventDispatchExtensions
    {
        /// <summary>
        /// Raises the <c>@onkeydown</c> event on <paramref name="element"/>,  passing the provided
        /// properties to the event handler via a <see cref="KeyboardEventArgs"/> object
        /// </summary>
        /// <param name="element">The element to raise the event on.</param>
        /// <param name="key">
        ///     The key value of the key represented by the event. If the value has a printed
        ///     representation, this attribute's value is the same as the char attribute. Otherwise,
        ///     it's one of the key value strings specified in 'Key values'. If the key can't
        ///     be identified, this is the string "Unidentified"
        /// </param>
        /// <param name="code">
        ///     Holds a string that identifies the physical key being pressed. The value is not
        ///     affected by the current keyboard layout or modifier state, so a particular key
        ///     will always return the same value.
        /// </param>
        /// <param name="location">The location of the key on the device.</param>
        /// <param name="repeat">true if a key has been depressed long enough to trigger key repetition, otherwise false.</param>
        /// <param name="ctrlKey">true if the control key was down when the event was fired. false otherwise.</param>
        /// <param name="shiftKey">true if the shift key was down when the event was fired. false otherwise.</param>
        /// <param name="altKey">true if the alt key was down when the event was fired. false otherwise.</param>
        /// <param name="metaKey">true if the meta key was down when the event was fired. false otherwise.</param>
        /// <param name="type">The type of the event.</param>
        public static void Keydown(this IElement element, string key, string? code = default, float location = default, bool repeat = default, bool ctrlKey = default, bool shiftKey = default, bool altKey = default, bool metaKey = default, string? type = default)
            => KeydownAsync(element, new KeyboardEventArgs { Key = key, Code = code, Location = location, Repeat = repeat, CtrlKey = ctrlKey, ShiftKey = shiftKey, AltKey = altKey, MetaKey = metaKey, Type = type });

        /// <summary>
        /// Raises the <c>@onkeydown</c> event on <paramref name="element"/>, passing the provided <paramref name="eventArgs"/>
        /// to the event handler.
        /// </summary>
        /// <param name="element">The element to raise the event on.</param>
        /// <param name="eventArgs">The event arguments to pass to the event handler.</param>
        public static void Keydown(this IElement element, KeyboardEventArgs eventArgs) => _ = KeydownAsync(element, eventArgs);

        /// <summary>
        /// Raises the <c>@onkeydown</c> event on <paramref name="element"/>, passing the provided <paramref name="eventArgs"/>
        /// to the event handler.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="eventArgs"></param>
        /// <returns>A task that completes when the event handler is done.</returns>
        public static Task KeydownAsync(this IElement element, KeyboardEventArgs eventArgs) => element.TriggerEventAsync("onkeydown", eventArgs);

        /// <summary>
        /// Raises the <c>@onkeyup</c> event on <paramref name="element"/>,  passing the provided
        /// properties to the event handler via a <see cref="KeyboardEventArgs"/> object
        /// </summary>
        /// <param name="element">The element to raise the event on.</param>
        /// <param name="key">
        ///     The key value of the key represented by the event. If the value has a printed
        ///     representation, this attribute's value is the same as the char attribute. Otherwise,
        ///     it's one of the key value strings specified in 'Key values'. If the key can't
        ///     be identified, this is the string "Unidentified"
        /// </param>
        /// <param name="code">
        ///     Holds a string that identifies the physical key being pressed. The value is not
        ///     affected by the current keyboard layout or modifier state, so a particular key
        ///     will always return the same value.
        /// </param>
        /// <param name="location">The location of the key on the device.</param>
        /// <param name="repeat">true if a key has been depressed long enough to trigger key repetition, otherwise false.</param>
        /// <param name="ctrlKey">true if the control key was down when the event was fired. false otherwise.</param>
        /// <param name="shiftKey">true if the shift key was down when the event was fired. false otherwise.</param>
        /// <param name="altKey">true if the alt key was down when the event was fired. false otherwise.</param>
        /// <param name="metaKey">true if the meta key was down when the event was fired. false otherwise.</param>
        /// <param name="type">The type of the event.</param>
        public static void Keyup(this IElement element, string key, string? code = default, float location = default, bool repeat = default, bool ctrlKey = default, bool shiftKey = default, bool altKey = default, bool metaKey = default, string? type = default)
            => KeyupAsync(element, new KeyboardEventArgs { Key = key, Code = code, Location = location, Repeat = repeat, CtrlKey = ctrlKey, ShiftKey = shiftKey, AltKey = altKey, MetaKey = metaKey, Type = type });

        /// <summary>
        /// Raises the <c>@onkeyup</c> event on <paramref name="element"/>, passing the provided <paramref name="eventArgs"/>
        /// to the event handler.
        /// </summary>
        /// <param name="element">The element to raise the event on.</param>
        /// <param name="eventArgs">The event arguments to pass to the event handler.</param>
        public static void Keyup(this IElement element, KeyboardEventArgs eventArgs) => _ = KeyupAsync(element, eventArgs);

        /// <summary>
        /// Raises the <c>@onkeyup</c> event on <paramref name="element"/>, passing the provided <paramref name="eventArgs"/>
        /// to the event handler.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="eventArgs"></param>
        /// <returns>A task that completes when the event handler is done.</returns>
        public static Task KeyupAsync(this IElement element, KeyboardEventArgs eventArgs) => element.TriggerEventAsync("onkeyup", eventArgs);

        /// <summary>
        /// Raises the <c>@onkeypress</c> event on <paramref name="element"/>,  passing the provided
        /// properties to the event handler via a <see cref="KeyboardEventArgs"/> object
        /// </summary>
        /// <param name="element">The element to raise the event on.</param>
        /// <param name="key">
        ///     The key value of the key represented by the event. If the value has a printed
        ///     representation, this attribute's value is the same as the char attribute. Otherwise,
        ///     it's one of the key value strings specified in 'Key values'. If the key can't
        ///     be identified, this is the string "Unidentified"
        /// </param>
        /// <param name="code">
        ///     Holds a string that identifies the physical key being pressed. The value is not
        ///     affected by the current keyboard layout or modifier state, so a particular key
        ///     will always return the same value.
        /// </param>
        /// <param name="location">The location of the key on the device.</param>
        /// <param name="repeat">true if a key has been depressed long enough to trigger key repetition, otherwise false.</param>
        /// <param name="ctrlKey">true if the control key was down when the event was fired. false otherwise.</param>
        /// <param name="shiftKey">true if the shift key was down when the event was fired. false otherwise.</param>
        /// <param name="altKey">true if the alt key was down when the event was fired. false otherwise.</param>
        /// <param name="metaKey">true if the meta key was down when the event was fired. false otherwise.</param>
        /// <param name="type">The type of the event.</param>
        public static void Keypress(this IElement element, string key, string? code = default, float location = default, bool repeat = default, bool ctrlKey = default, bool shiftKey = default, bool altKey = default, bool metaKey = default, string? type = default)
            => KeypressAsync(element, new KeyboardEventArgs { Key = key, Code = code, Location = location, Repeat = repeat, CtrlKey = ctrlKey, ShiftKey = shiftKey, AltKey = altKey, MetaKey = metaKey, Type = type });

        /// <summary>
        /// Raises the <c>@onkeypress</c> event on <paramref name="element"/>, passing the provided <paramref name="eventArgs"/>
        /// to the event handler.
        /// </summary>
        /// <param name="element">The element to raise the event on.</param>
        /// <param name="eventArgs">The event arguments to pass to the event handler.</param>
        public static void Keypress(this IElement element, KeyboardEventArgs eventArgs) => _ = KeypressAsync(element, eventArgs);

        /// <summary>
        /// Raises the <c>@onkeypress</c> event on <paramref name="element"/>, passing the provided <paramref name="eventArgs"/>
        /// to the event handler.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="eventArgs"></param>
        /// <returns>A task that completes when the event handler is done.</returns>
        public static Task KeypressAsync(this IElement element, KeyboardEventArgs eventArgs) => element.TriggerEventAsync("onkeypress", eventArgs);
    }
}