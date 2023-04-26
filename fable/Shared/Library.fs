module Shared

open System

type Album =
    { id: int
      title: string
      genre: string
      released: DateTime }

type NewAlbumInfo =
    { title: string
      genre: string
      released: DateTime }

// The shared interface representing your client-server interaction
type IMusicStore =
    { popularAlbums: unit -> Async<list<Album>> }
