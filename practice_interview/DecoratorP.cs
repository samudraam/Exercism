
// ============================================================
// ASSIGNMENT 01 — Decorator Pattern (Vehicle Status domain)
// ============================================================
//
// GOAL:
// Apply the Decorator pattern to the exact scenario from your
// interview prep: an operator's status panel that can optionally
// show a "stale data" warning and/or a "critical battery" warning,
// in any combination, decided at runtime.
//
//
// RULES:
// - Don't look back at the LoudAnimal example while you write this.
//   If you get stuck, that's useful information — note where you
//   got stuck, submit what you have, and we'll fix the gap.
// - Every TODO must be filled in. Nothing else needs to change.
// ============================================================
 
 
using System;
 
public class Program
{
    public static void Main()
    {
        IStatusDisplay display = new BasicStatusDisplay("Railcar-07", 42.0);
 
        Console.WriteLine("--- Plain display ---");
        display.Render();
 
        // TODO 1:
        // Wrap `display` in a StaleDataDecorator and call Render() on the
        // wrapped version. Print a separator line before it like above.
        Console.WriteLine("--- StaleDataDecorator display ---");
        IStatusDisplay disp = new StaleDataDecorator(display);
        disp.Render();
 
        // TODO 2:
        // Wrap `display` in a CriticalBatteryDecorator instead (separately,
        // not stacked yet) and call Render(). Print a separator line.
        Console.WriteLine("--- CriticalBatteryDecorator display ---");
        IStatusDisplay disp1 = new CriticalBatteryDecorator(display);
        disp1.Render();
        // TODO 3:
        // Now wrap `display` in BOTH decorators at once — stale AND critical
        // battery — and call Render(). Order of wrapping is your choice,
        // but be ready to explain why you chose that order.
        Console.WriteLine("--- StaleDataDecorator AND CriticalBatteryDecorator display ---");
        IStatusDisplay disp2 = new CriticalBatteryDecorator(new StaleDataDecorator(display));
        disp2.Render();
    }
}
 
// ------------------------------------------------------------
// The interface every display (plain or decorated) must implement.
// ------------------------------------------------------------
public interface IStatusDisplay
{
    void Render();
}
 
// ------------------------------------------------------------
// The base, undecorated display. Already written for you.
// ------------------------------------------------------------
public class BasicStatusDisplay : IStatusDisplay
{
    private readonly string _vehicleId;
    private readonly double _batteryPercent;
 
    public BasicStatusDisplay(string vehicleId, double batteryPercent)
    {
        _vehicleId = vehicleId;
        _batteryPercent = batteryPercent;
    }
 
    public void Render()
    {
        Console.WriteLine($"[{_vehicleId}] Battery: {_batteryPercent}%");
    }
}
 
// ------------------------------------------------------------
// TODO 4: Write StaleDataDecorator.
//
// Requirements:
// - Implements IStatusDisplay
// - Constructor takes an IStatusDisplay (not a BasicStatusDisplay —
//   this matters, think about why)
// - Render() should call the wrapped display's Render() first,
//   then print a warning line like: "  ⚠ WARNING: data may be stale"
// ------------------------------------------------------------
 
public class StaleDataDecorator : IStatusDisplay
{
    // TODO: fields, constructor, Render()
    private readonly IStatusDisplay _inner;
    public StaleDataDecorator(IStatusDisplay inner) => _inner = inner;

    public void Render()
    {
        _inner.Render();
        Console.WriteLine("⚠ WARNING: data may be stale");

    }
}
 
 
// ------------------------------------------------------------
// TODO 5: Write CriticalBatteryDecorator.
//
// Requirements:
// - Same shape as StaleDataDecorator
// - Render() should call the wrapped display's Render() first,
//   then print: "  🔋 CRITICAL: battery low"
// ------------------------------------------------------------
 
public class CriticalBatteryDecorator : IStatusDisplay
{
    // TODO: fields, constructor, Render()
    private readonly IStatusDisplay _inner;
    public  CriticalBatteryDecorator(IStatusDisplay inner) => _inner = inner;

    public void Render()
    {
        _inner.Render();
        Console.WriteLine("🔋 CRITICAL: battery low");

    }
}
 
 
// ============================================================
// EXPECTED OUTPUT SHAPE (yours will vary slightly based on order,
// that's fine — the point is the composition, not exact match):
//
// --- Plain display ---
// [Railcar-07] Battery: 42%
// --- Stale ---
// [Railcar-07] Battery: 42%
//   ⚠ WARNING: data may be stale
// --- Critical battery ---
// [Railcar-07] Battery: 42%
//   🔋 CRITICAL: battery low
// --- Both ---
// [Railcar-07] Battery: 42%
//   ⚠ WARNING: data may be stale
//   🔋 CRITICAL: battery low
// ============================================================