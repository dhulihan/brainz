package responses

import "github.com/jpdillingham/brainz/model"

type ReleaseGroupResponse struct {
	ReleaseGroups      []model.ReleaseGroup `json:"release-groups"`
	ReleaseGroupCount  int                  `json:"release-group-count"`
	ReleaseGroupOffset int                  `json:"release-group-offset"`
}
