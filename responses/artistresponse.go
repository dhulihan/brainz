package responses

import (
	"time"

	"github.com/jpdillingham/brainz/model"
)

// ArtistResponse encapsulates the response received from an artist search.
type ArtistResponse struct {
	Created time.Time      `json:"created"`
	Count   int            `json:"count"`
	Offset  int            `json:"offset"`
	Artists []model.Artist `json:"artists"`
}
