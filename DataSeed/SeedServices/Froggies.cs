using Cosmos.Models;

namespace DataSeed.SeedServices;

public static class Froggies
{
    public static readonly Frog[] Frogs = new Frog[]
    {
    new Frog(new Guid("4b18cde7-01f2-4e49-9f55-720e6fc8bb2c"), "404", "This frog likes to explore the internet."),
    new Frog(new Guid("f8a8c72d-0fa3-4ee0-8ed6-6e11a40df947"), "frog", "A classic froggy friend."),
    new Frog(new Guid("d6f29f3f-52f2-4c6e-8009-17cda5356467"), "moss", "Camouflaged like its namesake."),
    new Frog(new Guid("07534f09-0e24-41a7-9779-1e8bb892dbb2"), "apple", "Delicious and juicy, but don't eat this one!"),
    new Frog(new Guid("849b0a14-5106-44a4-a892-25f63d03371a"), "spots", "Has unique spots all over its body."),
    new Frog(new Guid("af6ac964-af9e-4705-bb3e-63bea30c4fd7"), "happy", "Always smiling and cheerful."),
    new Frog(new Guid("a07c2d57-86ad-4ed3-a2d8-7d8c46b98b3d"), "froggers", "Part of a frog band, loves to jam."),
    new Frog(new Guid("3b94e9c4-93de-4c87-b5fc-6d4562b44a0f"), "angry", "Watch out for this one when it's angry!"),
    new Frog(new Guid("1742f5c2-63ac-4974-b489-1aa97bb3d8b2"), "wholesome", "Brings warmth and positivity."),
    new Frog(new Guid("2bf9d1a3-4d35-4aaf-ba34-65d51b7b54ef"), "plant", "Loves to hop around in gardens."),
    new Frog(new Guid("3025e8a2-8cb2-4a90-bb28-4a8b69547e82"), "berry", "Has a sweet disposition."),
    new Frog(new Guid("55e758d8-b52f-4d9a-9393-20d86a7bc258"), "smile", "Brings joy with its infectious smile."),
    new Frog(new Guid("b19f70c3-30d3-4ba7-99a6-3ec1892588fb"), "wizard", "Master of magical leaps and bounds."),
    new Frog(new Guid("f28c09bc-ae3c-44ae-b8e3-b9864e3fe9a2"), "run", "Always on the move, never stopping."),
    new Frog(new Guid("c75bdcf5-760b-41b9-b5e4-c0240e7d6571"), "king", "Rules over the lilypads with grace and majesty."),
    new Frog(new Guid("ae869181-bb97-42f8-a62d-228025c7c42b"), "rainbow", "Brings color to every leap."),
    new Frog(new Guid("a20fd319-14c4-4fd4-97c2-b21b3ac352b8"), "orange", "Bright and vibrant, like the fruit."),
    new Frog(new Guid("eb48c8a1-8c0d-4851-a35e-67e36d67d858"), "bruh", "Says 'bruh' a lot, but still a good friend."),
    new Frog(new Guid("9e5e3a02-d61c-4cb4-bc6c-ea6b5885b784"), "froccs", "Froccs its way into your heart."),
    new Frog(new Guid("d2a04381-8f4a-4899-bdfb-fef59b893b86"), "pink", "Pretty in pink."),
    new Frog(new Guid("d25fc9e1-bf30-41c4-924d-25e15d0490ed"), "red", "Passionate and fiery."),
    new Frog(new Guid("70a457b4-7e32-441d-b189-3195757a6ed9"), "sad", "Sometimes feels blue."),
    new Frog(new Guid("6c55a317-20e1-4a69-91e3-1d87e0e7744f"), "smol", "Adorably small and cute."),
    new Frog(new Guid("226f108d-0505-43b7-8672-01992d3fc5e1"), "royal", "Regal and dignified."),
    new Frog(new Guid("55fc17ff-d5d7-43e8-a243-7a5a6288d3bb"), "cowboy", "Rides the range with a hop and a leap."),
    new Frog(new Guid("d65a5c23-0c79-4a57-b3cb-759ae5c20c9c"), "witch", "Casts spells with its croak."),
    new Frog(new Guid("7e90601f-b573-4539-af27-d4364e90b97c"), "teacup", "Prefers to hop around teacups."),
    new Frog(new Guid("027f0a24-ba6d-49e7-8e8d-42a12022ae39"), "grass", "Hides in the tall grass."),
    new Frog(new Guid("65ae6152-0c0d-4c62-953d-cdbf5a2b507f"), "shelf", "Perches on shelves."),
    new Frog(new Guid("9e15da1a-0da3-43b3-8fe3-2e906dc32a1a"), "tiny", "Smallest frog you've ever seen."),
    new Frog(new Guid("e172085e-d15f-42b5-8f1b-c3e66c2d8326"), "squish", "Likes to squish into small spaces."),
    new Frog(new Guid("9fa5b456-3b39-42b7-b944-9e73be8a4f0b"), "car", "Hops faster than a speeding car."),
    new Frog(new Guid("b4e080e5-7243-42b7-bd45-e3007df46006"), "clean", "Always keeps its lilypad tidy."),
    new Frog(new Guid("5dcb448c-56bb-44c7-b818-0f5e4892a489"), "peekaboo", "Loves playing peekaboo."),
    new Frog(new Guid("690774f3-0c43-497e-8093-914e3a02e3f9"), "buff", "Buff and tough."),
    new Frog(new Guid("2ab3a9a5-6b68-441a-9b7d-408d8e6091a1"), "smart", "The brainiest frog you'll meet."),
    new Frog(new Guid("4d3c1532-507d-4da1-85a4-6636c7d4fc32"), "stack", "Stacks things with its tongue."),
    new Frog(new Guid("b8580f40-2f2e-4ae1-8994-e74d31c9e3f5"), "strawberry", "Tastes like strawberries."),
    new Frog(new Guid("7b7a55c0-b6b9-45a3-a29b-e49b2f28540b"), "magic", "Performs magical leaps."),
    new Frog(new Guid("7b4630b2-970a-49c7-8841-23057d06fd21"), "fairy", "Sprinkles fairy dust with every leap."),
    new Frog(new Guid("97f2d6bc-4d18-4fd8-bb81-f02d61a4cf80"), "blue", "Cool and calm like the ocean."),
    new Frog(new Guid("ca4e509c-0e39-4c9f-8bc1-8f8ba28a364e"), "pirate", "Sails the seven lilypads."),
    };
}