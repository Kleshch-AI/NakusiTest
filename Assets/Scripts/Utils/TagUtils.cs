namespace NakusiTest.Utils
{

    public static class TagUtils
    {

        private const string RoomBounds = "RoomBounds";
        private const string Character = "Character";
        private const string Wall = "Wall";

        public static bool IsRoomBounds(string tag) => tag == RoomBounds;
        public static bool IsCharacter(string tag) => tag == Character;
        public static bool IsWall(string tag) => tag == Wall;

    }

}