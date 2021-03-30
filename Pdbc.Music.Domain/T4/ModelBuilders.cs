




using System;
using System.Linq;



using Pdbc.Music.Common;

namespace Pdbc.Music.Domain.Model {
    public partial class AlbumBuilder : ObjectBuilder<Pdbc.Music.Domain.Model.Album>
	{
       protected System.Collections.Generic.IList<Pdbc.Music.Domain.Model.Song> Songs { get; set; } = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
		
public AlbumBuilder WithSongs(params Pdbc.Music.Domain.Model.Song[] songs)
{
	Songs = songs.ToList();
	return this;
}
			


public virtual AlbumBuilder AddSongsItem(Pdbc.Music.Domain.Model.Song item)
{
	if (Songs == null) {
		Songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
	}

	this.Songs.Add(item);
	return this;
}

public virtual bool ContainsSongsItem(Pdbc.Music.Domain.Model.Song item)
{
    if (Songs != null)
    {
        return this.Songs.Contains(item);
    }
    return false;
}

public virtual AlbumBuilder RemoveSongsItem(Pdbc.Music.Domain.Model.Song item)
{
	if (Songs == null) {
		Songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
	}

	this.Songs.Remove(item);
	return this;
}
public virtual AlbumBuilder ClearSongs()
{
	if (Songs == null) {
		Songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
	}

	this.Songs.Clear();
	return this;
}




//public virtual AlbumBuilder WithSongs(params Action<Pdbc.Music.Domain.Model.SongBuilder>[] builders)
//{
	//var songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
//
	//foreach(var builder in builders)
	//{
		//var b = new Pdbc.Music.Domain.Model.SongBuilder();
		//builder.Invoke(b);
		//songs.Add(b.Build());
	//}
//
	//this.Songs  = songs;
//
	//return this;
//}

//public AlbumBuilder AddSongsItem(Pdbc.Music.Domain.Model.Song item)
//{
	//if (Songs == null) {
		//Songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
	//}
//
	//this.Songs.Add(item);
	//return this;
//}


protected System.String Name { get; set; }		
public AlbumBuilder WithName(System.String name)
{
    this.Name = name;
	return this;
}	



public override Album Build()
{
    var item = (Album)Activator.CreateInstance(typeof(Album));
    	
		
	item.Songs = Songs;
	    	
		
	item.Name = Name;
	    
    return item;
}
       
    }
}

namespace Pdbc.Music.Domain.Model {
    public partial class ArtistBuilder : ObjectBuilder<Pdbc.Music.Domain.Model.Artist>
	{
       protected System.Collections.Generic.IList<Pdbc.Music.Domain.Model.Song> Songs { get; set; } = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
		
public ArtistBuilder WithSongs(params Pdbc.Music.Domain.Model.Song[] songs)
{
	Songs = songs.ToList();
	return this;
}
			


public virtual ArtistBuilder AddSongsItem(Pdbc.Music.Domain.Model.Song item)
{
	if (Songs == null) {
		Songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
	}

	this.Songs.Add(item);
	return this;
}

public virtual bool ContainsSongsItem(Pdbc.Music.Domain.Model.Song item)
{
    if (Songs != null)
    {
        return this.Songs.Contains(item);
    }
    return false;
}

public virtual ArtistBuilder RemoveSongsItem(Pdbc.Music.Domain.Model.Song item)
{
	if (Songs == null) {
		Songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
	}

	this.Songs.Remove(item);
	return this;
}
public virtual ArtistBuilder ClearSongs()
{
	if (Songs == null) {
		Songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
	}

	this.Songs.Clear();
	return this;
}




//public virtual ArtistBuilder WithSongs(params Action<Pdbc.Music.Domain.Model.SongBuilder>[] builders)
//{
	//var songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
//
	//foreach(var builder in builders)
	//{
		//var b = new Pdbc.Music.Domain.Model.SongBuilder();
		//builder.Invoke(b);
		//songs.Add(b.Build());
	//}
//
	//this.Songs  = songs;
//
	//return this;
//}

//public ArtistBuilder AddSongsItem(Pdbc.Music.Domain.Model.Song item)
//{
	//if (Songs == null) {
		//Songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
	//}
//
	//this.Songs.Add(item);
	//return this;
//}


protected System.String Name { get; set; }		
public ArtistBuilder WithName(System.String name)
{
    this.Name = name;
	return this;
}	
protected System.Boolean IsDuplicate { get; set; }		
public ArtistBuilder WithIsDuplicate(System.Boolean isduplicate)
{
    this.IsDuplicate = isduplicate;
	return this;
}	



public override Artist Build()
{
    var item = (Artist)Activator.CreateInstance(typeof(Artist));
    	
		
	item.Songs = Songs;
	    	
		
	item.Name = Name;
	    	
		
	item.IsDuplicate = IsDuplicate;
	    
    return item;
}
       
    }
}

namespace Pdbc.Music.Domain.Model {
    public partial class FileInformationBuilder : ObjectBuilder<Pdbc.Music.Domain.Model.FileInformation>
	{
       protected System.String CurrentFullPath { get; set; }		
public FileInformationBuilder WithCurrentFullPath(System.String currentfullpath)
{
    this.CurrentFullPath = currentfullpath;
	return this;
}	
protected System.String Filename { get; set; }		
public FileInformationBuilder WithFilename(System.String filename)
{
    this.Filename = filename;
	return this;
}	
protected System.String Directory { get; set; }		
public FileInformationBuilder WithDirectory(System.String directory)
{
    this.Directory = directory;
	return this;
}	
protected System.String Extension { get; set; }		
public FileInformationBuilder WithExtension(System.String extension)
{
    this.Extension = extension;
	return this;
}	



public override FileInformation Build()
{
    var item = (FileInformation)Activator.CreateInstance(typeof(FileInformation));
    	
		
	item.CurrentFullPath = CurrentFullPath;
	    	
		
	item.Filename = Filename;
	    	
		
	item.Directory = Directory;
	    	
		
	item.Extension = Extension;
	    
    return item;
}
       
    }
}

namespace Pdbc.Music.Domain.Model {
    public partial class GenreBuilder : ObjectBuilder<Pdbc.Music.Domain.Model.Genre>
	{
       protected System.Collections.Generic.IList<Pdbc.Music.Domain.Model.Song> Songs { get; set; } = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
		
public GenreBuilder WithSongs(params Pdbc.Music.Domain.Model.Song[] songs)
{
	Songs = songs.ToList();
	return this;
}
			


public virtual GenreBuilder AddSongsItem(Pdbc.Music.Domain.Model.Song item)
{
	if (Songs == null) {
		Songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
	}

	this.Songs.Add(item);
	return this;
}

public virtual bool ContainsSongsItem(Pdbc.Music.Domain.Model.Song item)
{
    if (Songs != null)
    {
        return this.Songs.Contains(item);
    }
    return false;
}

public virtual GenreBuilder RemoveSongsItem(Pdbc.Music.Domain.Model.Song item)
{
	if (Songs == null) {
		Songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
	}

	this.Songs.Remove(item);
	return this;
}
public virtual GenreBuilder ClearSongs()
{
	if (Songs == null) {
		Songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
	}

	this.Songs.Clear();
	return this;
}




//public virtual GenreBuilder WithSongs(params Action<Pdbc.Music.Domain.Model.SongBuilder>[] builders)
//{
	//var songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
//
	//foreach(var builder in builders)
	//{
		//var b = new Pdbc.Music.Domain.Model.SongBuilder();
		//builder.Invoke(b);
		//songs.Add(b.Build());
	//}
//
	//this.Songs  = songs;
//
	//return this;
//}

//public GenreBuilder AddSongsItem(Pdbc.Music.Domain.Model.Song item)
//{
	//if (Songs == null) {
		//Songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
	//}
//
	//this.Songs.Add(item);
	//return this;
//}


protected System.String Name { get; set; }		
public GenreBuilder WithName(System.String name)
{
    this.Name = name;
	return this;
}	



public override Genre Build()
{
    var item = (Genre)Activator.CreateInstance(typeof(Genre));
    	
		
	item.Songs = Songs;
	    	
		
	item.Name = Name;
	    
    return item;
}
       
    }
}

namespace Pdbc.Music.Domain.Model {
    public partial class PlaylistBuilder : ObjectBuilder<Pdbc.Music.Domain.Model.Playlist>
	{
       protected System.String Name { get; set; }		
public PlaylistBuilder WithName(System.String name)
{
    this.Name = name;
	return this;
}	
protected System.Collections.Generic.IList<Pdbc.Music.Domain.Model.Song> Songs { get; set; } = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
		
public PlaylistBuilder WithSongs(params Pdbc.Music.Domain.Model.Song[] songs)
{
	Songs = songs.ToList();
	return this;
}
			


public virtual PlaylistBuilder AddSongsItem(Pdbc.Music.Domain.Model.Song item)
{
	if (Songs == null) {
		Songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
	}

	this.Songs.Add(item);
	return this;
}

public virtual bool ContainsSongsItem(Pdbc.Music.Domain.Model.Song item)
{
    if (Songs != null)
    {
        return this.Songs.Contains(item);
    }
    return false;
}

public virtual PlaylistBuilder RemoveSongsItem(Pdbc.Music.Domain.Model.Song item)
{
	if (Songs == null) {
		Songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
	}

	this.Songs.Remove(item);
	return this;
}
public virtual PlaylistBuilder ClearSongs()
{
	if (Songs == null) {
		Songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
	}

	this.Songs.Clear();
	return this;
}




//public virtual PlaylistBuilder WithSongs(params Action<Pdbc.Music.Domain.Model.SongBuilder>[] builders)
//{
	//var songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
//
	//foreach(var builder in builders)
	//{
		//var b = new Pdbc.Music.Domain.Model.SongBuilder();
		//builder.Invoke(b);
		//songs.Add(b.Build());
	//}
//
	//this.Songs  = songs;
//
	//return this;
//}

//public PlaylistBuilder AddSongsItem(Pdbc.Music.Domain.Model.Song item)
//{
	//if (Songs == null) {
		//Songs = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Song>();
	//}
//
	//this.Songs.Add(item);
	//return this;
//}





public override Playlist Build()
{
    var item = (Playlist)Activator.CreateInstance(typeof(Playlist));
    	
		
	item.Name = Name;
	    	
		
	item.Songs = Songs;
	    
    return item;
}
       
    }
}

namespace Pdbc.Music.Domain.Model {
    public partial class SongBuilder : ObjectBuilder<Pdbc.Music.Domain.Model.Song>
	{
       protected System.String Title { get; set; }		
public SongBuilder WithTitle(System.String title)
{
    this.Title = title;
	return this;
}	
protected System.TimeSpan Duration { get; set; }		
public SongBuilder WithDuration(System.TimeSpan duration)
{
    this.Duration = duration;
	return this;
}	
protected System.Int32 Year { get; set; }		
public SongBuilder WithYear(System.Int32 year)
{
    this.Year = year;
	return this;
}	
protected Pdbc.Music.Domain.Model.Album Album { get; set; }		
public SongBuilder WithAlbum(Pdbc.Music.Domain.Model.Album album)
{
    this.Album = album;
	return this;
}	

public SongBuilder WithAlbum(Action<Pdbc.Music.Domain.Model.AlbumBuilder> albumBuilder)
{
	var b = new Pdbc.Music.Domain.Model.AlbumBuilder();
	albumBuilder.Invoke(b);
	this.Album = b.Build();
	return this;
}


protected System.Collections.Generic.IList<Pdbc.Music.Domain.Model.Genre> Genres { get; set; } = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Genre>();
		
public SongBuilder WithGenres(params Pdbc.Music.Domain.Model.Genre[] genres)
{
	Genres = genres.ToList();
	return this;
}
			


public virtual SongBuilder AddGenresItem(Pdbc.Music.Domain.Model.Genre item)
{
	if (Genres == null) {
		Genres = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Genre>();
	}

	this.Genres.Add(item);
	return this;
}

public virtual bool ContainsGenresItem(Pdbc.Music.Domain.Model.Genre item)
{
    if (Genres != null)
    {
        return this.Genres.Contains(item);
    }
    return false;
}

public virtual SongBuilder RemoveGenresItem(Pdbc.Music.Domain.Model.Genre item)
{
	if (Genres == null) {
		Genres = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Genre>();
	}

	this.Genres.Remove(item);
	return this;
}
public virtual SongBuilder ClearGenres()
{
	if (Genres == null) {
		Genres = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Genre>();
	}

	this.Genres.Clear();
	return this;
}




//public virtual SongBuilder WithGenres(params Action<Pdbc.Music.Domain.Model.GenreBuilder>[] builders)
//{
	//var genres = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Genre>();
//
	//foreach(var builder in builders)
	//{
		//var b = new Pdbc.Music.Domain.Model.GenreBuilder();
		//builder.Invoke(b);
		//genres.Add(b.Build());
	//}
//
	//this.Genres  = genres;
//
	//return this;
//}

//public SongBuilder AddGenresItem(Pdbc.Music.Domain.Model.Genre item)
//{
	//if (Genres == null) {
		//Genres = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Genre>();
	//}
//
	//this.Genres.Add(item);
	//return this;
//}


protected System.Collections.Generic.IList<Pdbc.Music.Domain.Model.Artist> Artists { get; set; } = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Artist>();
		
public SongBuilder WithArtists(params Pdbc.Music.Domain.Model.Artist[] artists)
{
	Artists = artists.ToList();
	return this;
}
			


public virtual SongBuilder AddArtistsItem(Pdbc.Music.Domain.Model.Artist item)
{
	if (Artists == null) {
		Artists = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Artist>();
	}

	this.Artists.Add(item);
	return this;
}

public virtual bool ContainsArtistsItem(Pdbc.Music.Domain.Model.Artist item)
{
    if (Artists != null)
    {
        return this.Artists.Contains(item);
    }
    return false;
}

public virtual SongBuilder RemoveArtistsItem(Pdbc.Music.Domain.Model.Artist item)
{
	if (Artists == null) {
		Artists = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Artist>();
	}

	this.Artists.Remove(item);
	return this;
}
public virtual SongBuilder ClearArtists()
{
	if (Artists == null) {
		Artists = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Artist>();
	}

	this.Artists.Clear();
	return this;
}




//public virtual SongBuilder WithArtists(params Action<Pdbc.Music.Domain.Model.ArtistBuilder>[] builders)
//{
	//var artists = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Artist>();
//
	//foreach(var builder in builders)
	//{
		//var b = new Pdbc.Music.Domain.Model.ArtistBuilder();
		//builder.Invoke(b);
		//artists.Add(b.Build());
	//}
//
	//this.Artists  = artists;
//
	//return this;
//}

//public SongBuilder AddArtistsItem(Pdbc.Music.Domain.Model.Artist item)
//{
	//if (Artists == null) {
		//Artists = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Artist>();
	//}
//
	//this.Artists.Add(item);
	//return this;
//}


protected System.Collections.Generic.IList<Pdbc.Music.Domain.Model.Playlist> Playlists { get; set; } = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Playlist>();
		
public SongBuilder WithPlaylists(params Pdbc.Music.Domain.Model.Playlist[] playlists)
{
	Playlists = playlists.ToList();
	return this;
}
			


public virtual SongBuilder AddPlaylistsItem(Pdbc.Music.Domain.Model.Playlist item)
{
	if (Playlists == null) {
		Playlists = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Playlist>();
	}

	this.Playlists.Add(item);
	return this;
}

public virtual bool ContainsPlaylistsItem(Pdbc.Music.Domain.Model.Playlist item)
{
    if (Playlists != null)
    {
        return this.Playlists.Contains(item);
    }
    return false;
}

public virtual SongBuilder RemovePlaylistsItem(Pdbc.Music.Domain.Model.Playlist item)
{
	if (Playlists == null) {
		Playlists = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Playlist>();
	}

	this.Playlists.Remove(item);
	return this;
}
public virtual SongBuilder ClearPlaylists()
{
	if (Playlists == null) {
		Playlists = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Playlist>();
	}

	this.Playlists.Clear();
	return this;
}




//public virtual SongBuilder WithPlaylists(params Action<Pdbc.Music.Domain.Model.PlaylistBuilder>[] builders)
//{
	//var playlists = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Playlist>();
//
	//foreach(var builder in builders)
	//{
		//var b = new Pdbc.Music.Domain.Model.PlaylistBuilder();
		//builder.Invoke(b);
		//playlists.Add(b.Build());
	//}
//
	//this.Playlists  = playlists;
//
	//return this;
//}

//public SongBuilder AddPlaylistsItem(Pdbc.Music.Domain.Model.Playlist item)
//{
	//if (Playlists == null) {
		//Playlists = new System.Collections.Generic.List<Pdbc.Music.Domain.Model.Playlist>();
	//}
//
	//this.Playlists.Add(item);
	//return this;
//}


protected Pdbc.Music.Domain.Model.FileInformation FileInformation { get; set; }		
public SongBuilder WithFileInformation(Pdbc.Music.Domain.Model.FileInformation fileinformation)
{
    this.FileInformation = fileinformation;
	return this;
}	

public SongBuilder WithFileInformation(Action<Pdbc.Music.Domain.Model.FileInformationBuilder> fileinformationBuilder)
{
	var b = new Pdbc.Music.Domain.Model.FileInformationBuilder();
	fileinformationBuilder.Invoke(b);
	this.FileInformation = b.Build();
	return this;
}


protected System.Boolean IsDuplicate { get; set; }		
public SongBuilder WithIsDuplicate(System.Boolean isduplicate)
{
    this.IsDuplicate = isduplicate;
	return this;
}	
protected System.String ModifiedBy { get; set; }		
public SongBuilder WithModifiedBy(System.String modifiedby)
{
    this.ModifiedBy = modifiedby;
	return this;
}	
protected System.DateTimeOffset ModifiedOn { get; set; }		
public SongBuilder WithModifiedOn(System.DateTimeOffset modifiedon)
{
    this.ModifiedOn = modifiedon;
	return this;
}	



public override Song Build()
{
    var item = (Song)Activator.CreateInstance(typeof(Song));
    	
		
	item.Title = Title;
	    	
		
	item.Duration = Duration;
	    	
		
	item.Year = Year;
	    	
		
	item.Album = Album;
	    	
		
	item.Genres = Genres;
	    	
		
	item.Artists = Artists;
	    	
		
	item.Playlists = Playlists;
	    	
		
	item.FileInformation = FileInformation;
	    	
		
	item.IsDuplicate = IsDuplicate;
	    	
		
	item.ModifiedBy = ModifiedBy;
	    	
		
	item.ModifiedOn = ModifiedOn;
	    
    return item;
}
       
    }
}
