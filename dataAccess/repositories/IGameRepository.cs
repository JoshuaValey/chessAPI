using chessAPI.dataAccess.models;
using chessAPI.models.game;


namespace chessAPI.dataAccess.repositories;



public interface IGameRepository<TI, TC>
        where TI : struct, IEquatable<TI>
        where TC : struct
{
    Task<TI> addGame(clsNewGame game);
    Task<IEnumerable<clsGameEntityModel<TI, TC>>> addGames(IEnumerable<clsNewGame> games);

    /*    Task<IEnumerable<clsGameEntityModel<TI, TC>>> getGamesByName(TI gameId)*/
    /// <summary>
    ///Obtener la información de un juego por medio de un id 
    /// </summary>
    /// <param name="gameId"></param>
    /// <returns></returns>
    Task<TI> getGame(TI gameId);

    Task updateGame(clsGame<TI> updateGame);

    Task deleteGame(TI id);

}
