

public static Rectangle GetBackgroundSourceRectangle(int gid, int tileSetDimension)
{
    int Column = (gid % tileSetDimension);
    int Row = (int)Math.Floor((float)gid / (float)tileSetDimension);
    int tileWidth = 16;
    //Note: Tiles are 16x16 in this case, so tile width is the same as height
    return new Rectangle((tileWidth * Column) + (3 * Column) + 1, (tileWidth * Row) + (3 * Row) + 1, tileWidth, tileWidth);
}